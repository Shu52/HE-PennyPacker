using System.Collections.Generic;
//Call in interface
using PennyPacker.Interfaces;

namespace PennyPacker.Models.Factories
{
//In this namespace, this class resides.
// Class has two types of generic values.
//It's has a relationship with the interface class of IFactory
//This class will be parent class to other classes.
    public class Factory<T, K> : IFactory<T>
    {
        //required by interface
        public List<T> employees { get; set; } = new List<T> ();
        //new list created by factory class
        public List<K> products { get; set; } = new List<K> ();
        
        //required by interface. Taco is employee here
        public void HireEmployee (T employee) {
        //Lists are like arrays. ADD list method is used to add employee. 
        //employee is a type of the generic type to the list
            employees.Add (employee);
        }
        //new method created by factory class
        public void MakeProduct (K product) {
        //adds product list of products
            products.Add (product);
        }
    }
}
