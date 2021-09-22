using System;
namespace CarSimulator
{
    public class Car
    {
        private double mass;
        private string model;
        private double dragArea;
        private double engineForce;
        public State myCarState;
        /// implement constructor and methods
        public Car(string make, double ma, double eForce, double dArea)
        {
            model = make;
            mass = ma;
            dragArea = dArea;
            engineForce = eForce;
            myCarState = new State();
        }
    
        public string getModel()
        {
            return model;
        }

        public double getMass()
        {
            return mass;
        }

        public void accelerate(bool on)
        {

        }

        public void drive (double dt)
        {
            double x0 = getState().position;
            double v0 = getState().velocity;
            double t0 = getState().time;
            double a = getState().accelation;

            
            double v = Physics1D.compute_velocity(v0, a, dt);
            double fd = 0.5 * 1.225 * dragArea * v * v;
            double x = Physics1D.compute_position(x0, v, dt);
            a = Physics1D.compute_acceleration(engineForce - fd, mass);
            
            myCarState.set(x,v,a,dt);
        }

        public State getState()
        {
            return myCarState;
        }
        //implement inheritence


    }
}
 