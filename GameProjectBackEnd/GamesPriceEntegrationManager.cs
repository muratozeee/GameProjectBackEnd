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
                Console.WriteLine("Game Name={0} * Game Price={1} * After Discount={2} Discount Type Student %30", studentSale.GameName, studentSale.GamePrice,studentSale.GamePrice *(1-(campaign.CampaignRate/100)));
            }

        }

        public void TeacherDiscount(List<GameSale> gameSalesTeacher, CampaignManager campaign)
        {
            Console.WriteLine("________________________________");


           
            foreach (var teacherSale in gameSalesTeacher)
            {
                Console.WriteLine("Game Name={0} * Game Price={1} * After Discount={2} Discount Type Teacher %25", teacherSale.GameName, teacherSale.GamePrice, teacherSale.GamePrice * (1 - (campaign.CampaignRate / 100)));
            }
        }
        public void PoliceDiscount(List<GameSale> gameSalesPolice, CampaignManager campaign)
        {
            Console.WriteLine("________________________________");

            
            foreach (var policeSale in gameSalesPolice)
            {
                Console.WriteLine("Game Name={0} * Game Price={1} * After Discount={2} Discount Type Police %20", policeSale.GameName, policeSale.GamePrice,policeSale.GamePrice * (1 - (campaign.CampaignRate / 100)));
            }
        }




    }
}
