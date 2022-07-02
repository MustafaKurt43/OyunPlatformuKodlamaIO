using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOGames
{
    class Program
    {
        static void Main(string[] args)
        {

            Gamer gamer = new Gamer() { id = 1, Ad = "Mustafa", Soyad = "KURT", Kimlik = "12377899908", DogumYili = 2001 };
            GamerManager gmngr = new GamerManager();
            gmngr.newKayit(gamer); //diğerlerini yazmaya gerek yok
            
            Games game1 = new Games() { Gameid = 1, GameName = "Mario", Price = 90 };
            Games game2 = new Games() { Gameid = 2, GameName = "Donkey Kong", Price = 60 };
            Games[] gamearray = new Games[] { game1, game2 };
            string EmiHmi;
            Console.WriteLine("Oyun Almak istiyor musunuz? E/H");
            EmiHmi = Console.ReadLine();
            if (EmiHmi == "E" || EmiHmi == "e")
            {
            a1:
                Console.WriteLine("Şuan Sistemimizde bulunan oyunlar:");
                foreach (Games game in gamearray)
                {
                    Console.WriteLine(Convert.ToString(game.Gameid) + " " + game.GameName + " " + game.Price);
                }
                Console.WriteLine("Almak istediğiniz oyunun yanındaki sayıyı giriniz");
                int oyunid = Convert.ToInt32(Console.ReadLine());
                // oyunid = (oyunid == 1 || oyunid == 2) ? goto a2; : goto a1;
                if (oyunid == 1 || oyunid == 2)
                {
                    goto a2;
                }
                else { goto a1; }
            a2:
                Console.WriteLine("İndirim Kuponunuz Var mı?");
                //vs vs böyle devam ediyor kupon kod stringi olursa price %20 düşücek vsvs
            } else
                
            Console.ReadLine();
        }
    }
}
