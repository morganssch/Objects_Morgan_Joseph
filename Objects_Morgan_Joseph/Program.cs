using System;


namespace Objects_Morgan_Joseph
{
    public class  Program
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer("Dell", "Laptop", false);
            IBootUp myBootUp = myComputer;
            Console.WriteLine(myComputer.Equals(myBootUp));

            Computer myOtherComputer = new Computer("Dell", "Laptop", false);
            Console.WriteLine(myComputer.Equals(myOtherComputer));

            string myString = myComputer.ToString();
            Console.WriteLine(myString == myComputer.ToString());
            Console.WriteLine(myString == myOtherComputer.ToString());

            Console.WriteLine(myComputer.GetType());
            Console.WriteLine(myBootUp.GetType());

            myOtherComputer.PowerOnOff();

           
            Console.WriteLine(myString.Contains('i'));

            Console.WriteLine(myString.ToUpper());

        }
    }
}
