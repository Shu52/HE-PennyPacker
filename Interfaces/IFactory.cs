using System.Collections.Generic;
using PennyPacker.Models.Workers;
/* each of these instances of GenericList<T>, every occurrence of T in the class is substituted at run time with the type argument.
By means of this substitution, we have created three separate type-safe and efficient objects using a single class definition.
*/
//Declare namespace
namespace PennyPacker.Interfaces {
    // interface name and generic type
    public interface IFactory<T> {
        //list og generic type
        List<T> employees { get; set; }
        //generic taco
        void HireEmployee (T taco);
    }
}
