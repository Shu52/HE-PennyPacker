using System.Collections.Generic;
using PennyPacker.Models.Workers;

namespace PennyPacker.Interfaces {
    public interface IFactory<T> {
        List<T> employees { get; set; }
        void HireEmployee (T taco);
    }
}