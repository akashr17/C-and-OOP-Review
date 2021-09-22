using System;
namespace CarSimulator
{
    public class Car
    {
        protected double mass;
        protected string model;
        protected double dragArea;
        protected double engineForce;
        public State myCarState;
        /// implement constructor and methods
        
        public Car()
        {
            this.model = "";
            this.mass = 0.0;
            this.dragArea = 0.0;
            this.engineForce = 0.0;
            this.myCarState = new State();
        }
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


    public class Prius : Car
    {
        public Prius () : base()
        {

        }
        public Prius (string model, double mass, double engineForce, double dragArea) : base (model, mass, engineForce, dragArea)
        {

        }
    }

    public class Tesla : Car
    {
        public Tesla() : base()
        {

        }
        public Tesla(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {

        }

    }

    public class Mazda : Car
    {
        public Mazda() : base()
        {

        }
        public Mazda(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {

        }
    }

    public class Herbie : Car
    {
        public Herbie() : base()
        {

        }
        public Herbie(string model, double mass, double engineForce, double dragArea) : base(model, mass, engineForce, dragArea)
        {

        }

        //override drive function
        public void drive(double dt)
        {
            // get the previous values
            double x0 = getState().position;
            double v0 = getState().velocity;
            double t0 = getState().time;
            double a = getState().acceleration;

            // calculate the new values
            double v = Physics1D.compute_velocity(v0, a, dt);
            double fd = -0.5 * 1.225 * this.dragArea * v * v; // negative air resistance
            double x = Physics1D.compute_position(x0, v, dt);
            a = Physics1D.compute_acceleration(engineForce - fd, mass);

            // update the state with new values
            this.myCarState.set(x, v, a, dt);
        }

    }
}
 