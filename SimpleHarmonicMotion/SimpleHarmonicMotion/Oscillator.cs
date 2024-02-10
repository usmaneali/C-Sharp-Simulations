using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleHarmonicMotion
{
    class Oscillator
    {
        //Data variables
        public float th, om, t, dt, L, g, FD, omD, q, T,m;
        public int n;
        //Constructor
        public Oscillator(float theta, float omega)
        {//Constructor for Ideal Simple Pendulum
            th = theta; om = omega; t = 0; dt = 0.04f; L = 1; g = 9.8f; m = 1;
        }
        public Oscillator(float theta, float omega, float q, float FD, float omD)
        {//Constructorr for Realistic Simple Pendulum
            th = theta; om = omega; t = 0; dt = 0.04f; L =9.8f; g = 9.8f; this.FD = FD;
            this.omD = omD; this.q = q; m = 1;
        }
        //other functions
        public void IdealOscillateEuler()
        {
            th = th + om * dt;
            om = om - (g / L) * th * dt;
             t = t + dt;
        }
        public void IdealOscillateCromer()
        {
        
            om = om - (g / L) * th * dt;
            th = th + om * dt;
            t = t + dt;
        }
        public void Damped()
        {

            om = om - ((g / L) * th+q*om) * dt;
            th = th + om * dt;
            t = t + dt;
        }
        public void DampedDriven()
        {

            om = om - ((g / L) * th+q*om-
                FD*(float)Math.Sin(omD*t)) * dt;
            th = th + om * dt;
            t = t + dt;
        }
        public void Chaotic()
        {

            om = om - ((g / L) *(float)Math.Sin(th)+q*om-
                FD*(float)Math.Sin(omD*t)) * dt;
            th = th + om * dt;
            t = t + dt;
        }
        public float TotalEnergy()
        {
            return (1/2*m*L*L*om*om+m*g*L*(1-(float)Math.Cos(th)));
        }


      
       
    }
}
