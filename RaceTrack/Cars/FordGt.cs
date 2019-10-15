using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Ford : RaceCar
    { 
        public Ford()
        {
            Name = "Ford ";
            TopSpeed = 110;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} Keep trying and roard!");
            
        }

        
            

        }

    }
