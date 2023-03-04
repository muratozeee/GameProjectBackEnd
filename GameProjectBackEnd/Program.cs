namespace GameProjectBackEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

           IGamer gamer1=new GamerManager() {NickName="Down",Password="3231212ms",E_Mail="malibu_cs@gmail.com" };
           IGamer gamer2 = new GamerManager() { NickName = "Alex", Password = "5343Ns", E_Mail = "carkus_123@gmail.com" };
           IGamer gamer3 = new GamerManager() { NickName = "Joseph", Password = "38598Kj", E_Mail = "toshias_2@hotmail.com" };

            e_GovermentManager gamer1Verification = new e_GovermentManager { TcId = "15544422141", Name = "Murat", Surname = "Oz", BirthOfDate = "23.12.1995",Status="Student" };
            e_GovermentManager gamer2Verification = new e_GovermentManager { TcId = "85465821445", Name = "Suat", Surname = "stlms", BirthOfDate = "12.11.1998", Status = "Teacher" };
            e_GovermentManager gamer3Verification = new e_GovermentManager { TcId = "58551214781", Name = "Faruk", Surname = "Coskun", BirthOfDate = "15.10.1988", Status = "Police" };

            List<IGamer> gamerlist=new List<IGamer>() {gamer1,gamer2,gamer3 };
            List<e_GovermentManager> gamerinfo = new List<e_GovermentManager>() {gamer1Verification,gamer2Verification,gamer3Verification};

            GamerManager gamerManager = new GamerManager();
            e_GovermentManager govermentManager = new e_GovermentManager();



            gamerManager.NewSıgnUp(gamer1, gamer1Verification);
           
            
            gamerManager.Update(gamer2, gamer2Verification);
            
            
            gamerManager.Delete(gamer3, gamer3Verification);

            govermentManager.Verification(gamer1, gamer1Verification);


            gamerManager.Gamerİnfo(gamerlist, gamerinfo);   


           




        }
    }
}