using System;
using System.Linq;
using System.Collections.Generic;
namespace CarSimulator
{
    public class Highway
    {
        static void Main(string[] args)
        {
            int fleetNumberPerType = 25;
            //Step 1: implement fleets of arrays/lists per vehicle type
            // and compute states

            //Step 2: implement all the fleet in one list and compute states

            Tesla[] myTeslas = new Tesla[fleetNumberPerType].Select(tesla => new Tesla("Tesla", 1500, 1000, 0.51)).ToArray();
            Prius[] myPriuses = new Prius[fleetNumberPerType].Select(prius => new Prius("Prius", 1000, 750, 0.43)).ToArray();
            Mazda[] myMazdas = new Mazda[fleetNumberPerType].Select(mazda => new Mazda("Mazda", 1340, 850, 0.31)).ToArray();
            Herbie[] myHerbies = new Herbie[fleetNumberPerType].Select(herbie => new Herbie("Herbie", 1500, 750, 0.6)).ToArray();

            // implementation for 1 large list 

            /*var myCars = new List<Car>();
            for (int i = 0; i < fleetNumberPerType; i++)
            {
                myCars.Add(new CarSimulator.Tesla("Tesla", 1500, 1000, 0.51));
                myCars.Add(new CarSimulator.Prius("Prius", 1000, 750, 0.43));
                myCars.Add(new CarSimulator.Mazda("Mazda", 1340, 850, 0.31));
                myCars.Add(new CarSimulator.Herbie("Herbie", 1500, 750, 0.6));
                // TO DO: Do the same for other class vehicles
            }*/

            double dt=1;
            // loop through the time and list to drive all the vehicles
            for (double t = 0; t < 60; t += dt)
            {
                for (int i = 0; i < fleetNumberPerType; i++)
                {
                    // implementation with 4 seperate list of cars
                    myTeslas[i].drive(t);
                    Console.WriteLine("Car:{0},t:{1}, a:{2}, v:{3}, x1:{4}", myTeslas[i].getModel(), myTeslas[i].getState().time, myTeslas[i].getState().acceleration, myTeslas[i].getState().velocity, myTeslas[i].getState().position);
                    
                    myPriuses[i].drive(t);
                    Console.WriteLine("Car:{0},t:{1}, a:{2}, v:{3}, x1:{4}", myPriuses[i].getModel(), myPriuses[i].getState().time, myPriuses[i].getState().acceleration, myPriuses[i].getState().velocity, myPriuses[i].getState().position);

                    myMazdas[i].drive(t);
                    Console.WriteLine("Car:{0},t:{1}, a:{2}, v:{3}, x1:{4}", myMazdas[i].getModel(), myMazdas[i].getState().time, myMazdas[i].getState().acceleration, myMazdas[i].getState().velocity, myMazdas[i].getState().position);

                    myHerbies[i].drive(t);
                    Console.WriteLine("Car:{0},t:{1}, a:{2}, v:{3}, x1:{4}", myHerbies[i].getModel(), myHerbies[i].getState().time, myHerbies[i].getState().acceleration, myHerbies[i].getState().velocity, myHerbies[i].getState().position);

                    // implementation with 1 large list
                    //myCars[i].drive(t);
                    //Console.WriteLine("Car:{0},t:{1}, a:{2}, v:{3}, x1:{4}, index{5}", myCars[i].getModel(), myCars[i].getState().time, myCars[i].getState().acceleration, myCars[i].getState().velocity, myCars[i].getState().position, i);
                }
            }



        }

    }
}
