using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.Models
{
    public class UserQuestion
    {
        public List<int> Id { get; set; }

        public UserQuestion()
        {
            Id = new List<int>();
        }

    }
}
