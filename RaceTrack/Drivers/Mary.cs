using RaceTrack.RaceTrack.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Drivers
{
   
    
        public class Mary : Driver, IMary
        {

           
           
                public Mary(RaceCar car ) : base(car)
                {
                    Name = "Mary";
                    SkillLevel = 10;
                }

                public override void Drive()
                {
                    Car.Accelerate(SkillLevel);
                }
            
                
                
            }
        
            
                
            }
        

