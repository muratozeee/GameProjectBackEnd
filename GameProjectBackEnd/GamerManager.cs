using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
    class GamerManager : Gamer
    {
 
        //we Manage the Gamers Methods in this class and we are showing in Display
        public void NewSıgnUp(Gamer gamer,e_GovermentManager e_goverment)
        {
            Console.WriteLine("      New Sign Up");

            Console.WriteLine("{0} created a new gamer NickName is  {1} ",e_goverment.Name,gamer.NickName);

            Console.WriteLine("---------------------");

            Console.WriteLine("  ");

           
        }
        public void Update(Gamer gamer, e_GovermentManager e_goverment)
        {
            Console.WriteLine("******Updated*******");
            Console.WriteLine($"Tc= {e_goverment.TcId} Name={e_goverment.Name} Gamer  Updated the own informations. ");

            gamer.NickName = "Dark";
            gamer.Password = "14454dsa";
            gamer.E_Mail = "coskun.gar@gmail.com";

            Console.WriteLine($"New NickName={gamer.NickName}        New Pasword={gamer.Password}      New E-Mail={gamer.E_Mail}");
            Console.WriteLine("------------------");


        }

        public void Delete(Gamer gamer, e_GovermentManager e_goverment) {

            Console.WriteLine("             Delete");

            Console.WriteLine($"Tc={e_goverment.TcId} Name={e_goverment.Name} Gamer Deleted tha account Nick Name={gamer.NickName}");
            Console.WriteLine("-------------");
        
        }

        //We Listed all gamers with informations and from e-goverment..!
        public void Gamerİnfo(List<Gamer> gamers,List<e_GovermentManager> goverments)
        {
            int i = 0;
            Console.WriteLine("    ");
            Console.WriteLine("*******Gamers İnfo*******");

            foreach (var a in gamers)
            {
                Console.WriteLine($"NickName={a.NickName} *** Password={a.Password} *** E-Mail={a.E_Mail}");
              
                Console.WriteLine($"Tc={goverments[i].TcId}" );
                Console.WriteLine($"Name= {goverments[i].Name}  Surname= {goverments[i].Surname}");
                Console.WriteLine($"Date of Birth= {goverments[i].BirthOfDate} Status= {goverments[i].Status}");
                i++;
                Console.WriteLine("*********************");

            }
            Console.WriteLine("   ");
            Console.WriteLine("--------------------");

        }


    }
}
