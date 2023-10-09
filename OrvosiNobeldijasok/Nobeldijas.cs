using System;
using System.Collections.Generic;
using System.Text;

namespace OrvosiNobeldijasok
{
    class Nobeldijas
    {
        //Év;Név;SzületésHalálozás;Országkód
        public int Ev { get; set; }
        public string Nev { get; set; }
        public int SzuletesHalalozas { get; set; }
        public string Orszagkod { get; set; }

        public Nobeldijas(string sorok)
        {
            string[] sor = sorok.Split(";");
            Ev = Convert.ToInt32(sor[0]);
            Nev = sor[1];
            //szuleteshalal 
            Orszagkod = sor[4];
        }
    }
}
