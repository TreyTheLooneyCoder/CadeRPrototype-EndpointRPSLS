using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CadeRPrototype_EndpointRPSLS.Services
{
    public class RPSLizardSpockServices
    {
        public string lizardSpock(string userChoice)
        {
            
            Random rng = new Random();
            int comChoiceNum = rng.Next(6);

            string comChoice = "";

            string result = "";
            
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

            if(userChoice == "")
            {
                return "Add something for real or stop wasting your time.";
            }


            // <------------------------- Rock ------------------------------>
            if(userChoice == "Rock" || userChoice == "rock" && comChoice == "Rock") 
            {
                result = "Computer chose rock you tied!";
            } 
            else if(userChoice == "Rock" || userChoice == "rock" && comChoice == "Paper") 
            {
                result = "Computer chose paper you lose!";
            } 
            else if(userChoice == "Rock" || userChoice == "rock" && comChoice == "Scissors") 
            {
                result = "Computer chose scissors you win!";
            } 
            else if(userChoice == "Rock" || userChoice == "rock" && comChoice == "Lizard") 
            {
                result = "Computer chose lizard you win!";
            } 
            else if(userChoice == "Rock" || userChoice == "rock" && comChoice == "Spock") 
            {
                result = "Computer chose spock you lose!";
            } 


            // <------------------------- Paper ------------------------------>
            if(userChoice == "Paper" || userChoice == "paper" && comChoice == "Rock") 
            {
                result = "Computer chose rock you win!";
            } 
            else if(userChoice == "Paper" || userChoice == "paper" && comChoice == "Paper") 
            {
                result = "Computer chose paper you tied!";
            }
            else if(userChoice == "Paper" || userChoice == "paper" && comChoice == "Scissors") 
            {
                result = "Computer chose scissors you lose!";
            } 
            else if(userChoice == "Paper" || userChoice == "paper" && comChoice == "Lizard") 
            {
                result = "Computer chose lizard you lose!";
            } 
            else if(userChoice == "Paper" || userChoice == "paper" && comChoice == "Spock")
            {
                result = "Computer chose spock you win!";
            } 
            

            // <------------------------- Scissors ------------------------------>
            if(userChoice == "Scissors" || userChoice == "scissors" && comChoice == "Rock") 
            {
                result = "Computer chose rock you lose!";
            } 
            else if(userChoice == "Scissors" || userChoice == "scissors" && comChoice == "Paper") 
            {
                result = "Computer chose paper you win!";
            } 
            else if(userChoice == "Scissors" || userChoice == "scissors" && comChoice == "Scissors") 
            {
                result = "Computer chose scissors you tied!";
            } 
            else if(userChoice == "Scissors" || userChoice == "scissors" && comChoice == "Lizard") 
            {
                result = "Computer chose lizard you win!";
            } 
            else if(userChoice == "Scissors" || userChoice == "scissors" && comChoice == "Spock") 
            {
                result = "Computer chose spock you lose!";
            } 


            // <------------------------- Lizard ------------------------------>
            if(userChoice == "Lizard" || userChoice == "lizard" && comChoice == "Rock") 
            {
                result = "Computer chose rock you lose!";
            } 
            else if(userChoice == "Lizard" || userChoice == "lizard" && comChoice == "Paper") 
            {
                result = "Computer chose paper you win!";
            } 
            else if(userChoice == "Lizard" || userChoice == "lizard" && comChoice == "Scissors") 
            {
                result = "Computer chose scissors you lose!";
            } 
            else if(userChoice == "Lizard" || userChoice == "lizard" && comChoice == "Lizard") 
            {
                result = "Computer chose lizard you tied!";
            } 
            else if(userChoice == "Lizard" || userChoice == "lizard" && comChoice == "Spock") 
            {
                result = "Computer chose spock you win!";
            }


            // <------------------------- Spock ------------------------------>
            if(userChoice == "Spock" || userChoice == "spock" && comChoice == "Rock")
            {
                result = "Computer chose rock you win!";
            } 
            else if(userChoice == "Spock" || userChoice == "spock" && comChoice == "Paper") 
            {
                result = "Computer chose paper you lose!";
            } 
            else if(userChoice == "Spock" || userChoice == "spock" && comChoice == "Scissors") 
            {
                result = "Computer chose scissors you win!";
            } 
            else if(userChoice == "Spock" || userChoice == "spock" && comChoice == "Lizard") 
            {
                result = "Computer chose lizard you lose!";
            } 
            else if(userChoice == "Spock" || userChoice == "spock" && comChoice == "Spock") 
            {
                result = "Computer chose spock you tied!";
            }
            
            return result;
        }
    }
}