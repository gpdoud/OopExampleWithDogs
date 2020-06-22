using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample {
    
    public class Collie : Canine {

        public bool IsLassie { get; set; } = false;

        public override string Bark() {
            return $"Yip!";
        }

        public void Herding() {
            Console.WriteLine("Our collie is herding");
        }

        public Collie(string name,  string color = "Brown", bool isLassie = false) : base() {
            TailLength = "Long";
            FurLength = "Long";
            Color = color;
            IsLassie = isLassie;
            Name = name;
        }
    }
}
