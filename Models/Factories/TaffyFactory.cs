using System.Collections.Generic;
using PennyPacker.Interfaces;
using PennyPacker.Models.Workers;

namespace PennyPacker.Models.Factories {
    public class TaffyFactory : IFactory<Confectioner> {
        public List<Confectioner> employees { get; set; } = new List<Confectioner> ();

        public void HireEmployee (Confectioner employee) {
            employees.Add (employee);
        }
    }
}