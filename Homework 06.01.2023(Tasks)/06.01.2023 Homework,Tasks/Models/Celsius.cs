using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._01._2023_Homework_Tasks.Models
{
    public class Celsius
    {
        public float Degree { get; set; }

        public Celsius(float degree)
        {
            Degree = degree;
        }


        public static implicit operator Kelvin(Celsius celsius)
        {
            return new Kelvin(celsius.Degree - 273);
        }

    }
}
