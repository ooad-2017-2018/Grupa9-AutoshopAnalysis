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
        private static IEnumerable<Automobil> AllOrders()
        {
            // The following is order summary data
            var data = new ObservableCollection<Automobil>
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

        // Ova se fja mjenja u zavisnosti sta nam treba
        public static ObservableCollection<DataPoint> GetChartSampleData()
        {
            var data = AllOrders().Select(o => new DataPoint() { Category = o.Proizvodjac, Value = o.Cijena })
                                  .OrderBy(dp => dp.Category);

            return new ObservableCollection<DataPoint>(data);
        }

        
        public static async Task<IEnumerable<Automobil>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllOrders();
        }
    }
}
