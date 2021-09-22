using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double acceleration;
        public double time;

        //implement methods like set, constructors (if applicable)

        public State() //default constructor with 0
        {
            this.position = 0.0;
            this.velocity = 0.0;
            this.acceleration = 0.0;
            this.time = 0.0;
        }

        public State(double position, double velocity, double acceleration, double time) // construtor with parameters
        {
            this.position = position;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.time = time;
        }

        public void set(double position, double velocity, double acceleration, double time)  //set method
        {
            this.position = position;
            this.velocity = velocity;
            this.acceleration = acceleration;
            this.time = time;
        }
       
    }
}
