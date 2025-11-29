using InfluencerManagerApp.Core.Contracts;
using InfluencerManagerApp.Models;
using InfluencerManagerApp.Models.Contracts;
using InfluencerManagerApp.Repositories;
using InfluencerManagerApp.Repositories.Contracts;
using InfluencerManagerApp.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Core
{
    public class Controller : IController
    {

        private const double MinBudgetTarget = 10_000;

        private IRepository<IInfluencer> influencers;
        private IRepository<ICampaign> campaigns;

        public Controller()
        {
            influencers = new InfluencerRepository();
            campaigns = new CampaignRepository();
        }
        public string ApplicationReport()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var influencer in influencers.Models.OrderByDescending(i => i.Income).ThenByDescending(i => i.Followers))
            {
                sb.AppendLine(influencer.ToString());

                if (influencer.Participations.Any())
                {
                    sb.AppendLine("Active Campaigns:");

                    foreach (var campaign in campaigns.Models.Where(c => c.Contributors.Contains(influencer.Username)).OrderBy(c => c.Brand))
                    {
                        sb.AppendLine($"--{campaign.ToString()}");
                    }
                }
            }

            return sb.ToString().TrimEnd();
        }

        public string AttractInfluencer(string brand, string username)
        {
            if (influencers.FindByName(username) == null)
                return string.Format(OutputMessages.InfluencerNotFound, nameof(InfluencerRepository), username);

            if (campaigns.FindByName(brand) == null)
                return string.Format(OutputMessages.CampaignNotFound, brand);

            IInfluencer creator = influencers.FindByName(username);
            ICampaign campaign = campaigns.FindByName(brand);

            if (campaign.Contributors.Contains(creator.Username))
                return string.Format (OutputMessages.InfluencerAlreadyEngaged, username , brand);

            bool isEligible = true;
            if (campaign.GetType().Name == nameof(ProductCampaign) && creator.GetType().Name == nameof(BloggerInfluencer))
            {
                isEligible = false;
            }
            if (campaign.GetType().Name == nameof(ServiceCampaign) && creator.GetType().Name == nameof(FashionInfluencer))
            {
                isEligible = false;
            }

            if (!isEligible)
            {
                return string.Format(OutputMessages.InfluencerNotEligibleForCampaign, username, brand);
            }

            double profit = creator.CalculateCampaignPrice();

            if (profit > campaign.Budget)
                return string.Format(OutputMessages.UnsufficientBudget, brand, username);

            creator.EarnFee(profit);
            creator.EnrollCampaign(brand);
            campaign.Engage(creator);

            return string.Format (OutputMessages.InfluencerAttractedSuccessfully,username , brand);
        }

        public string BeginCampaign(string typeName, string brand)
        {
            if (typeName != nameof(ProductCampaign) && typeName != nameof(ServiceCampaign))
                return string.Format(OutputMessages.CampaignTypeIsNotValid, typeName);

            if (campaigns.Models.Any(c => c.Brand == brand))
                return string.Format (OutputMessages.CampaignDuplicated, brand);

            ICampaign campaign;
            if (typeName == nameof(ServiceCampaign))
                campaign = new ServiceCampaign(brand);
            else 
                campaign = new ProductCampaign(brand);
            campaigns.AddModel(campaign);

            return string.Format(OutputMessages.CampaignStartedSuccessfully, brand, typeName);
        }

        public string CloseCampaign(string brand)
        {
            if (campaigns.FindByName(brand) == null)
                return OutputMessages.InvalidCampaignToClose;

            ICampaign campaign = campaigns.FindByName(brand);
            
            if (campaign.Budget <= MinBudgetTarget)
                return string.Format(OutputMessages.CampaignCannotBeClosed, brand);
            else
            {
                foreach (var creator in campaign.Contributors)
                {
                    var currCreator = influencers.FindByName(creator);
                    currCreator.EarnFee(2000);
                    currCreator.EndParticipation(campaign.Brand);
                }    
            }

            campaigns.RemoveModel(campaign);

            return string.Format (OutputMessages.CampaignClosedSuccessfully, brand);
        }

        public string ConcludeAppContract(string username)
        {
            if (influencers.FindByName(username) == null)
                return string.Format(OutputMessages.InfluencerNotSigned, username);

            IInfluencer influencer = influencers.FindByName(username);

            if (influencer.Participations.Count > 0)
                return string.Format(OutputMessages.InfluencerHasActiveParticipations, username);

            influencers.RemoveModel(influencer);
            return string.Format(OutputMessages.ContractConcludedSuccessfully, username);
        }

        public string FundCampaign(string brand, double amount)
        {
            if (campaigns.FindByName(brand) == null)
                return OutputMessages.InvalidCampaignToFund;

            if (amount <= 0)
                return OutputMessages.NotPositiveFundingAmount;

            ICampaign campaign = campaigns.FindByName(brand);
            campaign.Gain(amount);

            return string.Format(OutputMessages.CampaignFundedSuccessfully,brand , amount);
        }

        public string RegisterInfluencer(string typeName, string username, int followers)
        {
            if (typeName != nameof(BusinessInfluencer) && typeName != nameof(BloggerInfluencer) && typeName != nameof(FashionInfluencer))
                return string.Format(OutputMessages.InfluencerInvalidType, typeName);

            if (influencers.Models.Any(i => i.Username == username))
                return string.Format (OutputMessages.UsernameIsRegistered, username, nameof (InfluencerRepository));

            var creator = CreateInfluencer(typeName, username, followers);

            
            influencers.AddModel(creator);

            return string.Format(OutputMessages.InfluencerRegisteredSuccessfully, username);
        }

        private IInfluencer CreateInfluencer(string typeName,string username, int followers)
        {
            IInfluencer creator;

            if (typeName == nameof(BusinessInfluencer))
                creator = new BusinessInfluencer(username, followers);
            else if (typeName == nameof(BloggerInfluencer))
                creator = new BloggerInfluencer(username, followers);
            else
                creator = new FashionInfluencer(username, followers);
            return creator;
        }
    }
}
