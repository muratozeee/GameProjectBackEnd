using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
    class GamerManager : IGamer
    {
        public string NickName { get; set; }
        public string Password { get ; set ; }
        public string E_Mail { get ; set; }

        public void NewSıgnUp(IGamer gamer,e_GovermentManager e_goverment)
        {
            Console.WriteLine("      New Sign Up");

            Console.WriteLine("{0} created a new gamer NickName is  {1} ",e_goverment.Name,gamer.NickName);

            Console.WriteLine("---------------------");

            Console.WriteLine("  ");

           
        }
        public void Update(IGamer gamer, e_GovermentManager e_goverment)
        {
            Console.WriteLine("******Updated*******");
            Console.WriteLine("Tc= {0} Name={1} Gamer  Updated the own informations. ",e_goverment.TcId,e_goverment.Name);

            gamer.NickName = "Dark";
            gamer.Password = "14454dsa";
            gamer.E_Mail = "coskun.gar@gmail.com";

            Console.WriteLine("New NickName={0}        New Pasword={1}      New E-Mail={2}",gamer.NickName,gamer.Password,gamer.E_Mail);
            Console.WriteLine("------------------");


        }

        public void Delete(IGamer gamer, e_GovermentManager e_goverment) {

            Console.WriteLine("             Delete");

            Console.WriteLine("Tc={0} Name={1} Gamer Deleted tha account Nick Name={2}", e_goverment.TcId, e_goverment.Name,gamer.NickName);
            Console.WriteLine("-------------");
        
        }
        public void Gamerİnfo(List<IGamer> gamers,List<e_GovermentManager> goverments)
        {
            int i = 0;
            Console.WriteLine("    ");
            Console.WriteLine("*******Gamers İnfo*******");

            foreach (var a in gamers)
            {
                Console.WriteLine("NickName={0} *** Password={1} *** E-Mail={2}",a.NickName,a.Password,a.E_Mail);
              
                Console.WriteLine("Tc=" + goverments[i].TcId);
                Console.WriteLine("Name= {0}  Surname= {1}", goverments[i].Name, goverments[i].Surname);
                Console.WriteLine("Date of Birth= {0} Status= {1}", goverments[i].BirthOfDate, goverments[i].Status);
                i++;
                Console.WriteLine("*********************");

            }
            Console.WriteLine("   ");
            Console.WriteLine("--------------------");

        }


    }
}
