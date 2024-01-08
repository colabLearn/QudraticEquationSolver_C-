using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutorialPractice
{
    internal class RootOfEquation
    {
        double a, b, c=0;

        //Get input from user through the textboxes
        public  void getABC_fromUser(
            string  inputA, 
            string  inputB, 
            string  inputC
            )
        { 
            this.a =  Double.Parse(inputA); 
            this.b = Double.Parse(inputB); 
            this.c = Double.Parse(inputC); 
        }

        //Returns the value of a 
        public double getA() { return this.a; } 
        
        //Return the vbalue of b
        public double getB() { return this.b;}

        //Return the vbalue of c
        public double getC() { return this.c;}

        //Calculate sqrt(b**2 - 4ac)
        private  double squareRootOutput()
        {
            double bSquare = Math.Pow( this.b, 2 );
            double four_ac = 4 * a * c;

            return Math.Sqrt(bSquare-four_ac);
        }


        /*
         * @Return: array of double with two elements
         * array[0]: -b+ sqrt(b**2 -4ac)
         * array[1]: -b- sqrt(b**2 - 4ac)
         */
        private double [] numerators()
        {
            double nume1 = -b+ this.squareRootOutput();
            double nume2 = -b- this.squareRootOutput();
            double[] numes = { nume1, nume2 };
            return numes;
        }

        /*
         * Computes the roots of the equation 
         * @Return: array with lenght 2
         * array[0]: root1
         * array[1]: root2
         * 
         */
        public  double[] rootsOfEqua()
        {
            double root1 = this.numerators()[0] / (2 * this.a);
            double root2 = this.numerators()[1] / (2 * this.a);

            double[] result = { root1, root2 }; 
            return result;
        }
    }
}
