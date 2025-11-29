using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class FashionInfluencer : Influencer
    {
        private const double EngamgementRate_Default = 4;
        private const double FactorPercent = 0.1;
        public FashionInfluencer(string username, int followers)
            : base(username, followers, EngamgementRate_Default)
        {
        }

        public override int CalculateCampaignPrice()
        {
           return (int)Math.Floor (Followers *  EngamgementRate_Default * FactorPercent);
        }
    }
}
