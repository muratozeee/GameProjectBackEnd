using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
    class GameSale : IGamer
    {
        public string NickName { get; set; }
        public string Password { get; set; }
        public string E_Mail { get; set; }

        public string GameName { get; set; }
        public  string GamePrice { get; set; }
        public string  GameMemory { get; set; }
        
        public void GameInfo(List<GameSale> games)

        {

            Console.WriteLine("***************");
            foreach (var products in games)

            {
                Console.WriteLine("Game Name={0} * Game Price={1} * Game Memory={2} *",products.GameName,products.GamePrice,products.GameMemory);

            }

        }


        public void GamesSale(IGamer gamer,GameSale gameSale)
        {
            Console.WriteLine("         ");
            Console.WriteLine(" *Games Sale*");
            Console.WriteLine("Game Name={0} was buyed by NickName={1} ",gameSale.GameName,gamer.NickName);

        }
    }
}
