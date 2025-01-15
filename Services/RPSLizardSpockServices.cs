using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRPrototype_EndpointRPSLS.Services
{
    public class RPSLizardSpockServices
    {
        public string lizardSpock(string comChoice)
        {
            Random rng = new Random();
            int comChoiceNum = rng.Next(6);

            switch(comChoiceNum)
            {
                case 1: 
                    comChoice = "Rock";
                    break;
                
                case 2: 
                    comChoice = "Paper";
                    break;
                
                case 3: 
                    comChoice = "Scissors";
                    break;

                case 4: 
                    comChoice = "Lizard";
                    break;

                case 5: 
                    comChoice = "Spock";
                    break;
            }
            
            return comChoice;
        }
    }
}