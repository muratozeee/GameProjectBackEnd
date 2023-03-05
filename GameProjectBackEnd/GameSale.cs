using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectBackEnd
{
    class GameSale : Gamer
    {
       

        public string GameName { get; set; }
        public  double GamePrice { get; set; }
        public string  GameMemory { get; set; }
        
        public void GameInfo(List<GameSale> games)

        {

            Console.WriteLine("***************");
            foreach (var products in games)

            {
                Console.WriteLine("Game Name={0} * Game Price={1} * Game Memory={2} *",products.GameName,products.GamePrice,products.GameMemory);

            }

        }


        public void GamesSale(Gamer gamer,GameSale gameSale)
        {
            Console.WriteLine("         ");
            Console.WriteLine(" *Games Sale*");
            Console.WriteLine($"Game Name={gameSale.GameName} was buyed by NickName= {gamer.NickName}");

        }


    }
}
