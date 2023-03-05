namespace GameProjectBackEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

           Gamer gamer1=new GamerManager() {NickName="Down",Password="3231212ms",E_Mail="malibu_cs@gmail.com" };
           Gamer gamer2 = new GamerManager() { NickName = "Alex", Password = "5343Ns", E_Mail = "carkus_123@gmail.com" };
           Gamer gamer3 = new GamerManager() { NickName = "Joseph", Password = "38598Kj", E_Mail = "toshias_2@hotmail.com" };

            e_GovermentManager gamer1Verification = new e_GovermentManager { TcId = "15544422141", Name = "Murat", Surname = "Oz", BirthOfDate = "23.12.1995",Status="Student" };
            e_GovermentManager gamer2Verification = new e_GovermentManager { TcId = "85465821445", Name = "Suat", Surname = "stlms", BirthOfDate = "12.11.1998", Status = "Teacher" };
            e_GovermentManager gamer3Verification = new e_GovermentManager { TcId = "58551214781", Name = "Faruk", Surname = "Coskun", BirthOfDate = "15.10.1988", Status = "Police" };

            List<Gamer> gamerlist=new List<Gamer>() {gamer1,gamer2,gamer3 };
            List<e_GovermentManager> gamerinfo = new List<e_GovermentManager>() {gamer1Verification,gamer2Verification,gamer3Verification};

            GamerManager gamerManager = new GamerManager();
            e_GovermentManager govermentManager = new e_GovermentManager();



            gamerManager.NewSıgnUp(gamer1, gamer1Verification);
           
            
            gamerManager.Update(gamer2, gamer2Verification);
            
            
            gamerManager.Delete(gamer3, gamer3Verification);

            govermentManager.Verification(gamer1, gamer1Verification);


            gamerManager.Gamerİnfo(gamerlist, gamerinfo);


            Console.WriteLine("-------------------Games---------------------------------");
            GameSale gamesSale = new GameSale();


            GameSale game1 = new GameSale() {GameName="Legue Of Legend",GamePrice=10,GameMemory="16.7 GB" };
            GameSale game2 = new GameSale() { GameName = "Metin 2", GamePrice = 5, GameMemory = "4.3 GB" };
            GameSale game3 = new GameSale() { GameName = "Wolfteam", GamePrice = 3, GameMemory = "11.5 GB" };
            GameSale game4 = new GameSale() { GameName = "Skyrim", GamePrice = 15, GameMemory = "35 GB" };
           
    
            

            List<GameSale> gamesInfo = new List<GameSale>() {game1,game2,game3,game4 };

            gamesSale.GameInfo(gamesInfo);

            gamesSale.GamesSale(gamer1,game2);

            



            CampaignManager campaign1 = new CampaignManager() { CampaignName = "Students Campaign Until September until %30 discount campaign..! Don't Missed İt",
            CampaignRate=50};
            CampaignManager campaing2 = new CampaignManager() { CampaignName = "Teachers Campaign valid for 30 days %25 Discount Campaign..!  ",CampaignRate=25 };

            CampaignManager campaign3 = new CampaignManager() { CampaignName="Polices Campaign Valid for 20 days %20 Discount Campaign..! They are working for our safety..!",CampaignRate=20 };
          
            List<CampaignManager> campaigns = new List<CampaignManager>() { campaign1,campaing2,campaign3 };
            CampaignManager campaign = new CampaignManager();

          
            campaign.CampaignEntry(campaigns,gamesInfo);

            Console.WriteLine("*********************************");
            campaign.CampaignEntity(campaign1);

            campaign.CampaignUpdate(campaing2);

            campaign.CampaignDelete(campaign3);




                Console.WriteLine("--------------Campaign Entegration-----");
            CampaignEntegrationManager campaignEntegration = new CampaignEntegrationManager();

            //we use the status for selecting.And we can see the display..!

            campaignEntegration.CampaignEntegration(gamer2Verification);

            campaignEntegration.CampaignEntegration(gamer1Verification);

            campaignEntegration.CampaignEntegration(gamer3Verification);
            
            //This one for showing different status for campaign.
            e_GovermentManager gamer4Verification = new e_GovermentManager { TcId = "58551214781", Name = "Faruk", Surname = "Coskun", BirthOfDate = "15.10.1988", Status = "doctor" };


            campaignEntegration.CampaignEntegration(gamer4Verification);



            Console.WriteLine("  ");

            Console.WriteLine("--- Discount of Games---");

            GamesPriceEntegrationManager gamesPriceEntegrationManager = new GamesPriceEntegrationManager();

            gamesPriceEntegrationManager.StudentDiscount(gamesInfo,campaign1);

            gamesPriceEntegrationManager.TeacherDiscount(gamesInfo,campaing2);

            gamesPriceEntegrationManager.PoliceDiscount(gamesInfo,campaign3);


























        }
    }
}