using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoShopAnalysis.Model
{
    class BankovniRacun
    {
        int stanjeRacuna;
        int brojRacuna;

        public int BrojRacuna { get => brojRacuna; set => brojRacuna = value; }

        public int StanjeRacuna { get => stanjeRacuna; set => stanjeRacuna = value; }

    }
}
