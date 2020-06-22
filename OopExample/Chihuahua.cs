using System;
using System.Collections.Generic;
using System.Text;

namespace OopExample {
    
    public class Chihuahua : Canine {

        public override string Bark() {
            return "Squeek";
        }

        public Chihuahua(string name, string color = "Light brown") : base() {
            Type = "Chihuahua";
            TailLength = "short";
            FurLength = "micrscopic";
            Color = color;
            Name = name;
        }
    }
}
