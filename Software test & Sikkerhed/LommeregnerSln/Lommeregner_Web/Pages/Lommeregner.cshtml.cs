using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Lommeregner_backend;
using System.ComponentModel;
using System.Threading;

namespace Lommeregner_Web.Pages
{
    public class LommeregnerModel : PageModel
    {
        [BindProperty]
        public  Calculator calc { get; set; }
       
        public LommeregnerModel(ICalculator calc)
        {
            this.calc = (Calculator)calc;      
        }
     
        public void OnPostAdd(float Keyboard)
        {
            calc.Add(Keyboard);
            //Thread.Sleep(new Random().Next(0,5000));
        }
        public void OnPostSub(float Keyboard)
        {
            calc.Subtract(Keyboard);
        }
    }
}