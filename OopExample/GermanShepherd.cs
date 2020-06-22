using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample {
    
    public class GermanShepherd : Canine {

        public override string Bark() {
            return "You better run!";
        }

        public GermanShepherd(string name, string color) : base() {
            this.Type = "GermanShepherd";
            TailLength = "Long";
            FurLength = "Long";
            Color = color;
            Name = name;
        }
        public GermanShepherd(string name) : this(name, "Brown") {

        }
    }
}
