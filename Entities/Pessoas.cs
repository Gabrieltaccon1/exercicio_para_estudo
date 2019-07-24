using System;
using System.Collections.Generic;
using System.Text;

namespace Desafio_sexta_26_07
{
    class Pessoas
    {
        public string _Id { get; set; }
        public string Index { get; set; }
        public string Guid { get; set; }
        public string IsActie { get; set; }
        public string Balance { get; set; }
        public string Picture { get; set; }
        public string Age { get; set; }
        public string EyeColor { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string About { get; set; }
        public string Registered { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public List<string> LstTags { get; set; } = new List<string>();
        public List<Friends> Friends { get; set; } = new List<Friends>();
        public string Greeting { get; set; }
        public string FavoriteFruit { get; set; }
  



        public string EmissaoDigital { get; set; }
        public string Sms { get; set; }
        public string Celular { get; set; }
     



    }
}
