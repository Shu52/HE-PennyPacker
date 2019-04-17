using System;
using PennyPacker.Models.Factories;
using PennyPacker.Models.Workers;

namespace PennyPacker
{
    class Program
    {
        static void Main(string[] args)
        {
            TaffyFactory kandyKorner = new TaffyFactory();
            kandyKorner.HireEmployee(new Confectioner {
                FirstName = "Susan",
                LastName = "Chung"
            });


            SteelFactory erieSteel = new SteelFactory();
            erieSteel.HireEmployee(new SteelWorker {
                FirstName = "Stewart",
                LastName = "Baut"
            });


            InsulinFactory johnsonChemical = new InsulinFactory();
            johnsonChemical.HireEmployee(new LabTechnician {
                FirstName = "Michael",
                LastName = "Bolt-on"
            });

            johnsonChemical.employees.ForEach(e =>
                Console.WriteLine($"{e.FirstName} {e.LastName}"));


            NuggetFactory flemingFoods = new NuggetFactory();
            flemingFoods.HireEmployee(new FoodProcessor {
                FirstName = "Ted",
                LastName = "Nuget"
            });


            CarFactory acmeAutos = new CarFactory();
            acmeAutos.HireEmployee(new AutoWorker {
                FirstName = "Chevy",
                LastName = "Ford"
            });

        }
    }
}
