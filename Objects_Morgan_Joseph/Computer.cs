using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects_Morgan_Joseph
{
    class Computer: IBootUp
    {
        

        public bool IsOn { get; set; } // Implement the IsOn property from the IBootUp interface

        public string Brand { get; set; } // Declare a property named Brand of type string with get and set accessors

        public string Type { get; set; } // Declare a property named Type of type string with get and set accessors

        public Computer(string brand, string type, bool isOn) // Define a constructor that takes three parameters: brand, type, and isOn
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }
        public void PowerOnOff()  // Implement the PowerOnOff method from the IBootUp interface
        {
            IsOn = !IsOn;

            if (IsOn == true) // Check if the computer is now on
            {
                Console.WriteLine("The computer is now booting up."); // Print a message to the console indicating that the computer is booting up
            }
            else
            {
                Console.WriteLine("The computer is shutting off."); // Print a message to the console indicating that the computer is shutting off
            }

        }

        public override string ToString() // Override the ToString() method to provide a string representation of the Computer object
        { 
            return $"The computer is made by {Brand} and is a {Type} computer."; // Return a formatted string that includes the Brand and Type properties of the Computer object
        }
    
    }
}
