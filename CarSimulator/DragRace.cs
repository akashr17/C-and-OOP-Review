using System;
namespace CarSimulator
{
    public class DragRace
    {
        static void Main(string[] args)
        {

            Car myTesla = new Car("Tesla", 1500, 1000, 0.51);
            Car myPrius = new Car("Prius", 1000, 750, 0.43);

            
            // drive for 60 seconds with delta time of 1s
            double dt = 1;

            for (double t = 0; t < 60; t += dt)
            {
                // drive function for both cars
                myTesla.drive(t);
                myPrius.drive(t);

                //use these variables to making accessing states easier
                State printT = myTesla.getState();
                State printP = myPrius.getState();

                //print the model, time. a , v, x for the 2 cars
                Console.WriteLine("Car:{0},t:{1}, a:{2}, v:{3}, x1:{4}", myTesla.getModel(), printT.time, printT.acceleration, printT.velocity, printT.position);
                Console.WriteLine("Car:{0},t:{1}, a:{2}, v:{3}, x1:{4} ", myPrius.getModel(), printP.time, printP.acceleration, printP.velocity, printP.position);

                // check who crosses first and if both cross within same timestamp, the car further ahead is the winner
                if (printT.position >= 402.3 | printP.position >= 402.3 )
                {
                    string winner;
                    if (printT.position > printP.position)
                    { winner = "Tesla"; }
                    else
                    {
                      winner = "Prius";
                    }
                    Console.WriteLine("The winner is {0}", winner);
                    break;
                }
                
            }
        }
    }
}
