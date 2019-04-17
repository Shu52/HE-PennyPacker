using System.Collections.Generic;
using PennyPacker.Interfaces;

namespace PennyPacker.Models.Factories
{
    public class Factory<T, K> : IFactory<T>
    {
        public List<T> employees { get; set; } = new List<T> ();
        public List<K> products { get; set; } = new List<K> ();

        public void HireEmployee (T employee) {
            employees.Add (employee);
        }

        public void MakeProduct (K product) {
            products.Add (product);
        }

    }
}