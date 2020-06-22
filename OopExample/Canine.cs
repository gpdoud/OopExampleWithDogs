using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample {
    
    public class Canine {

        public string Name { get; set; } = "A dog";
        public string TailLength { get; set; } = "";
        public string FurLength { get; set; } = "";
        public string Color { get; set; }
        public string Type { get; set; } = "Canine";

        public virtual string Bark() { return "Woof!"; }

        public bool Sit() { return true; }

        public Canine() {

        }
    }
}
