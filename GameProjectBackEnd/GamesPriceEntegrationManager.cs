using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
     class GamesPriceEntegrationManager:GameSale
    {
        public void StudentDiscount(List<GameSale> gameSalesstudent)
        {
            Console.WriteLine("________________________________");


            foreach (var studentSale in gameSalesstudent)
            {
                Console.WriteLine("Game Name={0} * Game Price={1} * After Discount={2} Discount Type Student %30", studentSale.GameName, studentSale.GamePrice,(studentSale.GamePrice*0.7));
            }

        }

        public void TeacherDiscount(List<GameSale> gameSalesTeacher)
        {
            Console.WriteLine("________________________________");


           
            foreach (var teacherSale in gameSalesTeacher)
            {
                Console.WriteLine("Game Name={0} * Game Price={1} * After Discount={2} Discount Type Teacher %25", teacherSale.GameName, teacherSale.GamePrice, (teacherSale.GamePrice * 0.75));
            }
        }
        public void PoliceDiscount(List<GameSale> gameSalesPolice)
        {
            Console.WriteLine("________________________________");

            
            foreach (var policeSale in gameSalesPolice)
            {
                Console.WriteLine("Game Name={0} * Game Price={1} * After Discount={2} Discount Type Police %20", policeSale.GameName, policeSale.GamePrice, (policeSale.GamePrice * 0.80));
            }
        }




    }
}
