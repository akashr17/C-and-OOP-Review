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
        public Car(string model, double mass, double engineForce, double dragArea)
        {
            this.model = model;
            this.mass = mass;
            this.dragArea = dragArea;
            this.engineForce = engineForce;
            this.myCarState = new State();  //create new state with all 0
        }
    
        public string getModel()
        {
            return this.model;
        }

        public double getMass()
        {
            return this.mass;
        }

        public void accelerate(bool on)
        {
            double x = getState().position;
            double v = getState().velocity;
            double t = getState().time;
            // check if on then stay same accerlation if not on then 0
            double a = on ? getState().acceleration : 0.0;
            // update state
            this.myCarState.set(x, v, a, t);
        }

        public void drive (double dt)
        {
            // get the previous values
            double x0 = getState().position;
            double v0 = getState().velocity;
            double t0 = getState().time;
            double a = getState().acceleration;

            // calculate the new values
            double v = Physics1D.compute_velocity(v0, a, dt);
            double fd = 0.5 * 1.225 * this.dragArea * v * v;
            double x = Physics1D.compute_position(x0, v, dt);
            a = Physics1D.compute_acceleration(engineForce - fd, mass);
            
            // update the state with new values
            this.myCarState.set(x,v,a,dt);
        }

        public State getState()
        {
            return this.myCarState;
        }
        //implement inheritence


    }
}
 