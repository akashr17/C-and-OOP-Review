using System;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello World!");
             Console.WriteLine(Physics1D.compute_position(1, 2.5, 10));
             Console.WriteLine(Physics1D.compute_velocity(2, 5, 10));
             Console.WriteLine(Physics1D.compute_acceleration(0, 0, 5, 1));
             Console.WriteLine(Physics1D.compute_velocity(0, 0, 10, 20));
             Console.WriteLine(Physics1D.compute_acceleration(10,2));*/

            // read in car mass
            Console.WriteLine("Enter the mass of the car (kg): ");
            double mass;
            mass = Convert.ToDouble(Console.ReadLine());

            // read in engine force
            Console.WriteLine("Enter the net force of the engine (N): ");
            double engine_force;
            engine_force = Convert.ToDouble(Console.ReadLine());

            // read in drag area coefficient
            Console.WriteLine("Enter the car's drag area*coefficent (m^2): ");
            double drag_area;
            drag_area = Convert.ToDouble(Console.ReadLine());

            // read in time step
            Console.WriteLine("Enter the simulation time step (s): ");
            double dt;
            dt = Convert.ToDouble(Console.ReadLine());

            // read in total number of simulation steps
            Console.WriteLine("Enter the number of time steps (int): ");
            int N;
            N = Convert.ToInt32(Console.ReadLine());

            // initialize the car's state
            double x0 = 0;  // initial position
            double v = 0;  // initial velocity
            double t = 0;  // initial time
            double fd, x1, a; // drag force and secondary position and acceleration
            
            a = Physics1D.compute_acceleration(engine_force, mass);

            // run the simulation
            for (int i = 0; i < N; ++i)
            {
                t += dt;  // increment time
                // TODO: COMPUTE UPDATED STATE HERE
                double v1 = Physics1D.compute_velocity(v, a, t);
                x1 = Physics1D.compute_position(x0, v1, t);
                fd = 0.5 * 1.225 * drag_area * v1*v1;

                a = Physics1D.compute_acceleration(engine_force - fd, mass);
                x0 = x1;
                v = v1;

                // print the time and current state
                Console.WriteLine("t:{0}, a:{1}, v:{2}, x1:{3}, fd:{4} ", t, a, v, x1, fd);
            }
        }
    }
}
