using System;
using System.Collections.Generic;
using System.Text;

namespace Lommeregner_backend
{
    public interface  ICalculator
    {
        public float CalculatorDisplayValue { get; set; }

        // Add  
        public void Add(float Enteredvalue);

        // Subtract  
        public void Subtract(float Enteredvalue);

        // Multiplication
        public void Multiply(float Enteredvalue);

        // Division
        public void Divide(float Enteredvalue);
     }


}
