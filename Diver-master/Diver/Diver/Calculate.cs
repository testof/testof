using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diver
{
    public class Calculate
    {
        public Calculate()
        {

        }

        public Calculate(double calculates)
        {
            this.Calculates = calculates;
        }
        private double _calculates;
        public double Calculates
        {
            get { return _calculates; }
            set { _calculates = value; }
        }
        public Boolean Valid()
        {
            if (Calculates > 0.0 && Calculates <= 10.0 && Calculates % 0.5 == 0.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double calculate()
        {
            int[] n = { 2, 3, 4, 5, 6 };
            int max = 0;
            int min = int.MaxValue;
            double sum = 0;
            double k = n.Sum();

            foreach (int i in n)

            {
                if (i > max)
                    max = i;
                if (i < min)
                    min = i;
                sum = k - max - min;
            }
            double j = sum / (n.Count() - 2);
            string myString = j.ToString();
            return j;

        }
    }
}
