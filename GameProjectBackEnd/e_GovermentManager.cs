using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
     class e_GovermentManager:IGamer
    {
        public string TcId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string BirthOfDate { get; set; }
        public string Status { get; set; }
        public string NickName { get; set; }
        public string Password { get; set; }
        public string E_Mail { get; set; }


        public void Verification(IGamer gamers,e_GovermentManager e_Goverment)
        {
            Console.WriteLine("****************");
            Console.WriteLine("           Verification");

            Console.WriteLine("Tc={0}  ,  Name={1} {2} gamer was confirmed Succesfully..!",e_Goverment.TcId,e_Goverment.Name,e_Goverment.Surname);
            Console.WriteLine("NickName={0} ",gamers.NickName);
        }











    }
}
