using System;


namespace Objects_Morgan_Joseph
{
    public class  Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Dell", "Laptop", false); // Create a new Computer object with brand "Dell", type "Laptop", and isOn set to false
            IBootUp myBootUp = myComputer; // Assign the myComputer object to an IBootUp interface variable
            Console.WriteLine(myComputer.Equals(myBootUp)); // Check if myComputer is equal to myBootUp (should be true since they refer to the same object)

            Computer myOtherComputer = new Computer("Dell", "Laptop", false); // Create another Computer object with the same properties as myComputer
            Console.WriteLine(myComputer.Equals(myOtherComputer)); // Check if myComputer is equal to myOtherComputer (should be false since they are different objects)

            string myString = myComputer.ToString(); // Call the ToString() method on myComputer and assign the result to myString
            Console.WriteLine(myString == myComputer.ToString()); // Check if myString is equal to the result of calling ToString() on myComputer (should be true)
            Console.WriteLine(myString == myOtherComputer.ToString()); //   Check if myString is equal to the result of calling ToString() on myOtherComputer (should be false since they are different objects)

            Console.WriteLine(myComputer.GetType()); // Get the type of myComputer and print it to the console
            Console.WriteLine(myBootUp.GetType()); // Get the type of myBootUp and print it to the console (should be the same as myComputer since they refer to the same object)

            myOtherComputer.PowerOnOff(); // Call the PowerOnOff() method on myOtherComputer to change its isOn property and print a message to the console


            Console.WriteLine(myString.Contains('i')); // Check if myString contains the character 'i' and print the result to the console

            Console.WriteLine(myString.ToUpper()); // Convert myString to uppercase and print the result to the console

        }
    }
}
