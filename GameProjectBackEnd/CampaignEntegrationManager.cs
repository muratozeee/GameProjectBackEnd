using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
     class CampaignEntegrationManager:CampaignManager
    {
        GameSale gameSale=new GameSale();
        public void CampaignEntegration(e_GovermentManager gamers)
        {
            //We are controlling which type of jop and you can use or cannot...
            if (gamers.Status == "Student")
            {
                Console.WriteLine("You can Use Student Campaign..!");

                
                
            }else if (gamers.Status == "Teacher")
            {
                Console.WriteLine("You can Use Teacher Campaign..!");

            }else if (gamers.Status=="Police")
            {
                Console.WriteLine("You can Use Police Campaign..!");
            }
            else
            {
                Console.WriteLine("You can not any use Campaign..!");
            }

        }
    }
}
