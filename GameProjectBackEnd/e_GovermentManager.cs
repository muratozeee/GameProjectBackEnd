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
    }
}
