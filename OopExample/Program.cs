using System;
using System.Threading.Tasks.Dataflow;

namespace OopExample {

    class Program {

        static void Main(string[] args) {

            var collie = new Collie("Lassie", "White", isLassie: true);
            Console.WriteLine($"{collie.Type}|{collie.IsLassie}|{collie.Color}|{collie.FurLength}|{collie.TailLength}");
            Console.WriteLine($"In response to bark(), our collie {collie.Bark()}");
            Console.WriteLine($"In response to sit(), our collie {collie.Sit()}");
            Console.WriteLine($"In response to hearding(), our collie");
            collie.Herding();

            var gs = new GermanShepherd("Police Dog");
            var barkValue = gs.Bark();

            var chi = new Chihuahua("Killer");
            var squeekValue = chi.Bark();

            Canine[] canines = new Canine[10];
            canines[0] = collie;
            canines[1] = gs;
            canines[2] = chi;

            for(var i = 0; i < canines.Length; i++) {
                var dog = canines[i];
                if(dog == null) 
                    break;
                var col = dog as Collie;
                if(col != null) {
                    col.Herding();
                }
                Console.WriteLine($"{dog.Name} is a {dog.Type}");
            }
        }
    }
}
