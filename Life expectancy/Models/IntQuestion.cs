using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.Models
{
    public class IntQuestion: Question
    {
        public double Value { get; set; }

        public IntQuestion(int id, string question, double value):base(id,question)
        {
            Value = value;
        }
    }
}
