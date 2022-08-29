using System;

namespace Scratchpaper
{
    public class Complex
    {
        public double rP; // real part
        public double iP; // imaginary part
        public void SetComplex(double r = 0, double i = 0)
        {
            rP = r;
            iP = i;
        }
        public void add(Complex c1)
        {
            rP += c1.rP;
            iP += c1.iP;
        }
        public void addTwo(Complex c1, Complex c2)
        {
            rP = c1.rP + c2.rP;
            iP = c1.iP + c2.iP;
        }
        public void sub(Complex c1)
        {
            rP -= c1.rP;
            iP -= c1.iP;
        }
        public void subTwo(Complex c1, Complex c2)
        {
            rP = c1.rP - c2.rP;
            iP = c1.iP - c2.rP;
        }
        public Complex mul(Complex c1)
        {
            Complex ccopy = new Complex();
            ccopy.rP = rP * c1.rP - iP * c1.iP;
            ccopy.iP = rP * c1.iP + iP * c1.rP;
            return ccopy;
        }
        public Complex div(Complex c1)
        {
            Complex ccopy = new Complex();
            ccopy.rP = ((rP * c1.rP) + (iP * c1.iP)) / ((c1.rP * c1.rP) + (c1.iP * c1.iP));
            ccopy.iP = ((iP * c1.rP) - (rP * c1.iP)) / ((c1.rP * c1.rP) + (c1.iP * c1.iP));
            if ((((c1.rP * c1.rP) + (c1.iP * c1.iP)) == 0) == false)
                return ccopy;
            else
            {
                ccopy.rP = 0;
                ccopy.iP = 0;
                return ccopy;
            }
        }
        public string polarForm()
        {
            double r = Math.Sqrt(iP * iP + rP * rP);
            double theta = Math.Atan(iP / rP);
            return ("Radius: "+ Math.Round(r, 3) + " " + "Angle: " + Math.Round(theta, 3));
        }
        public string power(double n)
        {
            Complex a = new Complex();
            a.SetComplex(rP, iP);
            Complex power = new Complex();
            power.SetComplex(rP, iP);
            for (int i = 0; i < n; i++)
                power = power.mul(a);
            return (Math.Round(power.rP, 3) + " + " + Math.Round(power.iP, 3) + "i");
        }
        public string toString()
        {
            return (Math.Round(rP, 3) + " + " + Math.Round(iP, 3) + "i");
        }       
    }
}