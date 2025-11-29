using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluencerManagerApp.Models
{
    public class BloggerInfluencer : Influencer
    {
        private const double EngamgementRate_Default = 2;
        private const double FactorPercent = 0.2;
        public BloggerInfluencer(string username, int followers) 
            : base(username, followers, EngamgementRate_Default)
        {
        }

        public override int CalculateCampaignPrice()
        {
            return (int)Math.Floor(Followers * EngamgementRate_Default * FactorPercent);
        }
    }
}
