using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
     class CampaignManager:GameSale
    {
        public string CampaignName { get; set; }

        public double CampaignRate { get; set; }



        public void CampaignEntity(CampaignManager campaign)
        {
            Console.WriteLine("{0} Which was Added..!",campaign.CampaignName);
        }

        public void CampaignDelete(CampaignManager campaign)
        {

            Console.WriteLine("{0} Which was Deleted..!", campaign.CampaignName);
        }
        public void CampaignUpdate(CampaignManager campaign)
        {

            Console.WriteLine("{0} Which was Updated..!", campaign.CampaignName);
        }

        public void CampaignEntry(List<CampaignManager> campaigns,List<GameSale> games)
        {

            Console.WriteLine("*************Campaign List With Games..!*************");

            foreach (var gms in campaigns)
            {
                Console.WriteLine(gms.CampaignName);
            }

            foreach (var gamess in games)
            {
                Console.WriteLine("********Games And Price*********");
                Console.WriteLine("Game= {0}      Price= {1}$",gamess.GameName,gamess.GamePrice);
            }
        }





    }
}
