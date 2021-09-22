using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double accelation;
        public double time;

        //implement methods like set, constructors (if applicable)

        public State() //default constructor with 0
        {
            position = 0.0;
            velocity = 0.0;
            accelation = 0.0;
            time = 0.0;
        }

        public State(double pos, double vel, double ac, double t) // construtor with parameters
        {
            position = pos;
            velocity = vel;
            accelation = ac;
            time = t;
        }

        public void set(double pos, double vel, double ac, double t)  //set method
        {
            position = pos;
            velocity = vel;
            accelation = ac;
            time = t;
        }
       
    }
}
