using System.Collections.Generic;
using PennyPacker.Interfaces;
using PennyPacker.Models.Workers;

namespace PennyPacker.Models.Factories {
    public class InsulinFactory : IFactory<LabTechnician> {
        public List<LabTechnician> employees { get; set; } = new List<LabTechnician> ();

        public void HireEmployee (LabTechnician employee) {
            employees.Add (employee);
        }
    }
}