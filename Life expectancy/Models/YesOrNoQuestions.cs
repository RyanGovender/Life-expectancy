using Life_expectancy.LogicLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.Models
{
    public class YesOrNoQuestions : Question
    {
        public List<string> YesorNo { get; set; }
        public YesOrNoQuestions(int id, string questionToAsk, List<double> values) : base(id, questionToAsk)
        {
            AllValues = values;
            DataTypes = DataTypes.StringValue;
            QuestionType = QuestionType.YesOrNoQuestion;
        }
    }
}
