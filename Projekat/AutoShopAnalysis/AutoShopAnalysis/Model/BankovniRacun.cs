using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace AutoShopAnalysis.Model
{
    public class BankovniRacun
    {
        int stanjeRacuna;
        int brojRacuna;

        public int BrojRacuna { get => brojRacuna; set => brojRacuna = value; }

        public int StanjeRacuna { get => stanjeRacuna; set => stanjeRacuna = value; }

    }
}
