using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{

        public class fouzia : Driver
        {
            public fouzia(RaceCar car) : base(car)
            {
                Name = "Fouzia";
                SkillLevel = 10;
            }

            public override void Drive()
            {
                Car.Accelerate(SkillLevel);
            }
        }
}
