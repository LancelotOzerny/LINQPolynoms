using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQPolinoms
{
    class Polynomial
    {

        //свойства
        private List<double> coefficients;
        private int count;


        //конструктор
        public Polynomial(int count)
        {
            this.count = count;
            coefficients = new List<double>(count);
            for (int i = 0; i < count; i++)
            {
                coefficients.Add(0);
            }
        }


        public double GetResult(double value)
        {
            double result = 0;
            for (int i = 0; i < coefficients.Count; i++)
            {
                if (coefficients[i] != 0)
                    result += coefficients[i] * Math.Pow(value, i);
            }
            return result;
        }
        public void SetCoefficient(double value, int position)
        {
            coefficients[position] = value;
        }
        public double GetCoefficient(int position)
        {
            return coefficients[position];
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            bool first = true;
            for (int i = 0; i < coefficients.Count; i++)
            {
                if (coefficients[i] != 0)
                {
                    if (first)
                    {
                        sb.Append(coefficients[i] > 0 ? "" : "-");
                        first = false;
                    }
                    else
                        sb.Append(coefficients[i] >= 0 ? "+" : "-");

                    sb.Append(coefficients[i].ToString());

                    if (i != 0)
                    {
                        sb.Append("*x^");
                        sb.Append(i.ToString());
                    }

                }
            }

            if (sb.Length == 0)
                sb.Append('0');

            return sb.ToString();
        }

        public static Polynomial plus(Polynomial a, Polynomial b)
        {
            Polynomial result = new Polynomial(100);
            for (int i = 0; i < 100; i++)
            {
                result.SetCoefficient(a.GetCoefficient(i) + b.GetCoefficient(i), i);
            }
            return result;
        }


        public static Polynomial minus(Polynomial a, Polynomial b)
        {
            Polynomial result = new Polynomial(100);
            for (int i = 0; i < 100; i++)
            {
                result.SetCoefficient(a.GetCoefficient(i) - b.GetCoefficient(i), i);
            }
            return result;
        }
        public static Polynomial multy(Polynomial a, Polynomial b)
        {
            Polynomial result = new Polynomial(200);
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    result.SetCoefficient(result.GetCoefficient(i + j) + a.GetCoefficient(i) * b.GetCoefficient(j), i + j);
                }
            }
            return result;
        }
        //перегрузка
        public static Polynomial operator +(Polynomial a, Polynomial b)
        {
            return Polynomial.plus(a, b);
        }
    }
}
