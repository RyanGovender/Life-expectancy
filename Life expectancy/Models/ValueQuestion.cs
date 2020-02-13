using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.Models
{
    public class ValueQuestion : Question
    {
        public ValueQuestion(int id, string questionToAsk,List<double> values) : base(id, questionToAsk)
        {
            AllValues = values;
            DataTypes = DataTypes.Integer;
            QuestionType = QuestionType.ValueQuestion;
        }
    }
}
