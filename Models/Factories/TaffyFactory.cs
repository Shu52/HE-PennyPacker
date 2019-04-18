using System.Collections.Generic;
using PennyPacker.Models.Workers;

namespace PennyPacker.Models.Factories {
    public class TaffyFactory {
        public List<Confectioner> employees { get; set; } = new List<Confectioner> ();

        public void HireEmployee (Confectioner employee) {
            employees.Add (employee);
        }
    }
}