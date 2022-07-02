using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIOGames
{
    public class Gamer
    {
        //interface yapınca hata çıkarttı .net versiyonum yeterli değilmiş galiba
        public int id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Kimlik { get; set; }
        public int DogumYili { get; set; }
    }
}
