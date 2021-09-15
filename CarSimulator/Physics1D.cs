using System;
namespace CarSimulator
{

    public class Physics1D
    {
        public static double compute_position(double x0, double v, double dt)
        {
            double x1 = v * dt + x0;
            return x1;
        }

        public static double compute_velocity(double v0, double a, double dt)
        {
            double v1 = a * dt + v0;
            return v1;
        }

        public static double compute_velocity(double x0, double t0, double x1, double t1)
        {
            double dx = x1 - x0;
            double dt = t1 - t0;
            return (dx / dt);
        }

        public static double compute_acceleration(double v0, double t0, double v1, double t1)
        {
            double dv = v1 - v0;
            double dt = t1 - t0;
            return (dv / dt);
        }

        public static double compute_acceleration(double f, double m)
        {
            double a = f / m;
            return a;
        }

    }         
}
