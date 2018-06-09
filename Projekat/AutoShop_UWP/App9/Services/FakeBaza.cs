using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App9.Model;
using App9.Models;

namespace App9.Services
{
    public static class FakeBaza
    {
        public static IEnumerable<Automobil> AllOrders()
        {
            // The following is order summary data
            var data = new List<Automobil>
            {
                new Automobil
                {
                    Proizvodjac = "BMW",
                    Cijena = 8000,
                    Prodan = true

                },
                new Automobil
                {
                    Proizvodjac = "Mercedes",
                    Cijena = 5200,
                    Prodan = true

                },
                new Automobil
                {
                    Proizvodjac = "Fiat",
                    Cijena = 10000,
                    Prodan = true

                },
                new Automobil
                {
                    Proizvodjac = "Toyota",
                    Cijena = 12300,
                    Prodan = true

                },
                new Automobil
                {
                    Proizvodjac = "Audi",
                    Cijena = 13200,
                    Prodan = true

                }
            };

            return data;
        }

        public static List<Automobil> listica = new List<Automobil>
            {
                new Automobil
                {
                    Proizvodjac = "BMW",
                    Cijena = 8000,
                    Prodan = true

                },
                new Automobil
                {
                    Proizvodjac = "Mercedes",
                    Cijena = 5200,
                    Prodan = true

                },
                new Automobil
                {
                    Proizvodjac = "Fiat",
                    Cijena = 10000,
                    Prodan = true

                },
                new Automobil
                {
                    Proizvodjac = "Toyota",
                    Cijena = 12300,
                    Prodan = true

                },
                new Automobil
                {
                    Proizvodjac = "Audi",
                    Cijena = 13200,
                    Prodan = true

                }
            };

        // Ova se fja mjenja u zavisnosti sta nam treba
        public static List<DataPoint> GetChartSampleData()
        {
  
            List<DataPoint> lista = new List<DataPoint>();
            DataPoint dataPoint = new DataPoint();
            dataPoint.Category = "1";
            dataPoint.Value = 15000;
            lista.Add(dataPoint);

            dataPoint = new DataPoint();
            dataPoint.Category = "2";
            dataPoint.Value = 12000;
            lista.Add(dataPoint);

            dataPoint = new DataPoint();
            dataPoint.Category = "3";
            dataPoint.Value = 5000;
            lista.Add(dataPoint);

            dataPoint = new DataPoint(); 
            dataPoint.Category = "4";
            dataPoint.Value = 45000;
            lista.Add(dataPoint);

            dataPoint = new DataPoint();
            dataPoint.Category = "5";
            dataPoint.Value = 75000;
            lista.Add(dataPoint);

            dataPoint = new DataPoint();
            dataPoint.Category = "6";
            dataPoint.Value = 150000;
            lista.Add(dataPoint);


            return lista;
        }


        public static List<DataPoint> GetChart1SampleData()
        {
            List<DataPoint> rezultat = new List<DataPoint>();

            for(int i=1; i<=listica.Count; i++)
            {
                DataPoint dataPoint = new DataPoint();
                dataPoint.Category = listica[i-1].Proizvodjac;
                dataPoint.Value = ((i*10000)%2500)+5800;
                rezultat.Add(dataPoint);
            }
            

            return rezultat;

        }




            public static async Task<IEnumerable<Automobil>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllOrders();
        }
    }
}
