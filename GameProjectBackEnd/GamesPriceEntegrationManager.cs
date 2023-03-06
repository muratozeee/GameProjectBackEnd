using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
     class GamesPriceEntegrationManager:GameSale
    {
        public void StudentDiscount(List<GameSale> gameSalesstudent,CampaignManager campaign)
        {
            Console.WriteLine("________________________________");


            foreach (var studentSale in gameSalesstudent)
            {
                Console.WriteLine($"Game Name={studentSale.GameName} * Game Price={studentSale.GamePrice} * After Discount={studentSale.GamePrice * (1 - (campaign.CampaignRate / 100))} Discount Type Student %30");
            }

        }

        public void TeacherDiscount(List<GameSale> gameSalesTeacher, CampaignManager campaign)
        {
            Console.WriteLine("________________________________");


           
            foreach (var teacherSale in gameSalesTeacher)
            {
                Console.WriteLine($"Game Name={teacherSale.GameName} * Game Price={teacherSale.GamePrice} * After Discount={teacherSale.GamePrice * (1 - (campaign.CampaignRate / 100))} Discount Type Teacher %25");
            }
        }
        public void PoliceDiscount(List<GameSale> gameSalesPolice, CampaignManager campaign)
        {
            Console.WriteLine("________________________________");

            
            foreach (var policeSale in gameSalesPolice)
            {
                Console.WriteLine($"Game Name={policeSale.GameName} * Game Price={policeSale.GamePrice} * After Discount={policeSale.GamePrice * (1 - (campaign.CampaignRate / 100))} Discount Type Police %20");
            }
        }




    }
}
