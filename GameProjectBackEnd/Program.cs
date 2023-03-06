namespace GameProjectBackEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //gamers defined the with informations.Gamer informations Data Base...!
           Gamer gamer1=new GamerManager() {NickName="Down",Password="3231212ms",E_Mail="malibu_cs@gmail.com" };
           Gamer gamer2 = new GamerManager() { NickName = "Alex", Password = "5343Ns", E_Mail = "carkus_123@gmail.com" };
           Gamer gamer3 = new GamerManager() { NickName = "Joseph", Password = "38598Kj", E_Mail = "toshias_2@hotmail.com" };

            //e-Goverment system was defined the gamers information to verification.Gamer Verification Data Base..!
            e_GovermentManager gamer1Verification = new e_GovermentManager { TcId = "15544422141", Name = "Murat", Surname = "Oz", BirthOfDate = "23.12.1995",Status="Student" };
            e_GovermentManager gamer2Verification = new e_GovermentManager { TcId = "85465821445", Name = "Suat", Surname = "stlms", BirthOfDate = "12.11.1998", Status = "Teacher" };
            e_GovermentManager gamer3Verification = new e_GovermentManager { TcId = "58551214781", Name = "Faruk", Surname = "Coskun", BirthOfDate = "15.10.1988", Status = "Police" };

            //Gamers and E-Goverment informations were listed...
            List<Gamer> gamerlist=new List<Gamer>() {gamer1,gamer2,gamer3 };
            List<e_GovermentManager> gamerinfo = new List<e_GovermentManager>() {gamer1Verification,gamer2Verification,gamer3Verification};

            //GamerManager and e_GovermentManager were defined the in  main class...!
            GamerManager gamerManager = new GamerManager();
            e_GovermentManager govermentManager = new e_GovermentManager();


            //We created the method to New Sıgnup gamer in GamerManager. We used the gamer1 information and gamer1verification. we are taking informations from gamers and verification data base...
            gamerManager.NewSıgnUp(gamer1, gamer1Verification);//gamer1 was Signed up by gamer1 and gamer1verification informations.
           
            //We created the method to GamerUpdate in GamerManager.We used the gamer2 information and gamer2verification.we are taking informations from gamers and verification data base...
            gamerManager.Update(gamer2, gamer2Verification);//

            //We created the method to GamerDelete in GamerManager.We used the gamer3 information and gamer3verification.we are taking informations from gamers and verification data base...

            gamerManager.Delete(gamer3, gamer3Verification);

            //we used the verfication method in govermentManager...
            govermentManager.Verification(gamer1, gamer1Verification);

            //We used the all gamers information to show display..!
            gamerManager.Gamerİnfo(gamerlist, gamerinfo);

            //We used the all information about gamers. first and second requirement are  finished.

            //we will create the Games data base
            Console.WriteLine("-------------------Games---------------------------------");
            GameSale gamesSale = new GameSale();

            // data base of games were created...
            GameSale game1 = new GameSale() {GameName="Legue Of Legend",GamePrice=10,GameMemory="16.7 GB" };
            GameSale game2 = new GameSale() { GameName = "Metin 2", GamePrice = 5, GameMemory = "4.3 GB" };
            GameSale game3 = new GameSale() { GameName = "Wolfteam", GamePrice = 3, GameMemory = "11.5 GB" };
            GameSale game4 = new GameSale() { GameName = "Skyrim", GamePrice = 15, GameMemory = "35 GB" };
           
    
            //Games were listed to show display.

            List<GameSale> gamesInfo = new List<GameSale>() {game1,game2,game3,game4 };

           //games were listed in display.
            gamesSale.GameInfo(gamesInfo);


            //We selected gamer1 buy game2 in this method.
            gamesSale.GamesSale(gamer1,game2);
            //third requirement is finished.


            

            //Campaigns were created as a Data base

            CampaignManager campaign1 = new CampaignManager() { CampaignName = "Students Campaign Until September until %30 discount campaign..! Don't Missed İt",
            CampaignRate=30};
            CampaignManager campaing2 = new CampaignManager() { CampaignName = "Teachers Campaign valid for 30 days %25 Discount Campaign..!  ",CampaignRate=25 };

            CampaignManager campaign3 = new CampaignManager() { CampaignName="Polices Campaign Valid for 20 days %20 Discount Campaign..! They are working for our safety..!",CampaignRate=20 };
          
            //Campaigns were listed...
            List<CampaignManager> campaigns = new List<CampaignManager>() { campaign1,campaing2,campaign3 };
            CampaignManager campaign = new CampaignManager();
            //Campaign class was defined the in main class...
          
            //Campaign entry method was created and using with campaigns and games info from data bases..
            campaign.CampaignEntry(campaigns,gamesInfo);

            Console.WriteLine("*********************************");

            //We used the Campaign properties with methods.
            campaign.CampaignEntity(campaign1);

            campaign.CampaignUpdate(campaing2);

            campaign.CampaignDelete(campaign3);
            //fourth requirement was finished.


            //we will do campaign entegration..!
                Console.WriteLine("--------------Campaign Entegration-----");
            CampaignEntegrationManager campaignEntegration = new CampaignEntegrationManager();


            //we use the status for selecting.And we can see the display..!

            //this one for which gamer can use campaign and prices we can select and choose properties in this methods.
            campaignEntegration.CampaignEntegration(gamer2Verification);

            campaignEntegration.CampaignEntegration(gamer1Verification);

            campaignEntegration.CampaignEntegration(gamer3Verification);
            
            //This one for showing different status for campaign.we didnt defined the doctor status campaign then what we will see . that's why ı added this data for showing.
            e_GovermentManager gamer4Verification = new e_GovermentManager { TcId = "58551214781", Name = "Faruk", Surname = "Coskun", BirthOfDate = "15.10.1988", Status = "doctor" };

            
            campaignEntegration.CampaignEntegration(gamer4Verification);




            Console.WriteLine("  ");

            Console.WriteLine("--- Discount of Games---");
            //We want to see games with discount and which status and how many discount like that in the display...!
            GamesPriceEntegrationManager gamesPriceEntegrationManager = new GamesPriceEntegrationManager();

            gamesPriceEntegrationManager.StudentDiscount(gamesInfo,campaign1);

            gamesPriceEntegrationManager.TeacherDiscount(gamesInfo,campaing2);

            gamesPriceEntegrationManager.PoliceDiscount(gamesInfo,campaign3);



        }
    }
}