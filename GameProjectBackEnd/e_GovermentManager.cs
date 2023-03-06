using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
     class e_GovermentManager:Gamer
    {
        public string TcId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
        public string Status { get; set; }
    


        public void Verification(Gamer gamers,e_GovermentManager e_Goverment)
        {
            Console.WriteLine("****************");
            Console.WriteLine("           Verification");

            Console.WriteLine($"Tc={e_Goverment.TcId}  ,  Name={e_Goverment.Name} {e_Goverment.Surname} gamer was confirmed Succesfully..!");
            Console.WriteLine($"NickName={gamers.NickName} ");
        }











    }
}
