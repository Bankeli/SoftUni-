using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class BusinessInfluencer : Influencer
    {
        private const double EngamgementRate_Default = 3;
        private const double FactorPercent = 0.15;
        public BusinessInfluencer(string username, int followers)
            : base(username, followers, EngamgementRate_Default)
        {
        }

        public override int CalculateCampaignPrice()
        {
            var result = Followers * EngagementRate * FactorPercent;
            return (int)Math.Floor(result);
        }
    }
}
