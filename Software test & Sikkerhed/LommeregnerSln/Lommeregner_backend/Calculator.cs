using System;

namespace Lommeregner_backend
{
    public class Calculator : ICalculator
    {
        public Calculator()
        {
        }
        public float CalculatorDisplayValue { get; set; }

        // Add  
        public void Add(float Enteredvalue)
        {
            CalculatorDisplayValue = CalculatorDisplayValue + Enteredvalue;
        }

        // Subtract  
        public void Subtract(float Enteredvalue)
        {
            CalculatorDisplayValue = CalculatorDisplayValue - Enteredvalue;
        }

        // Multiply
        public void Multiply(float Enteredvalue)
        {
            CalculatorDisplayValue = CalculatorDisplayValue * Enteredvalue;
        }
  
        // Divide
        public void Divide(float Enteredvalue)
        {
            CalculatorDisplayValue = CalculatorDisplayValue / Enteredvalue;
        }
    }
}
