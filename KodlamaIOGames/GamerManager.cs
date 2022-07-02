using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOGames
{
    class GamerManager
    {
        public void newKayit(Gamer gamer)
        {
            Gamer _gamer = new Gamer();
            Console.WriteLine("New user added");
        }

        public void Update(Gamer gamer)
        {
            Gamer _gamer = new Gamer();
            Console.WriteLine("User updated");
        }
        public void Delete(Gamer gamer)
        {
            Gamer _gamer = new Gamer();
            Console.WriteLine("User Deleted");
        }

    }
}
