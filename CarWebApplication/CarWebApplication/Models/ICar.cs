using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWebApplication.Models
{
    public interface ICar
    {
        string Color { get; set; }
        int NumberOfSeats { get; set; }
        string Model { get; set; }
        decimal Price { get; set; }
        void EnterGas();
    }

    public interface IToyota : ICar
    {
        string EngineType { get; set; }   //// E,J,G,T

    }
    public interface IMercedes : ICar
    {
        string ModelType { get; set; }   //// Sedan or hatchback
    }

    public class ToYoTa : IToyota
    {
        public string EngineType { get; set; }
        public string Color { get; set; }
        public int NumberOfSeats { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public void EnterGas()
        {
            Console.WriteLine("Input Mogas Diesel A95");
        }
    }

    public class Mercedes : IMercedes
    {
        public string ModelType { get; set; }
        public string Color { get; set; }
        public int NumberOfSeats { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }

        public void EnterGas()
        {
            Console.WriteLine("Mercedes input Mogas Diesel E5");
        }
    }
}
