﻿using System.Collections.Generic;

namespace Life_expectancy.Models
{
    public class YesOrNoQuestions : Question
    {
        public List<double> AllValues {get;}
        public YesOrNoQuestions(int id, string questionToAsk, List<double> values) : base(id, questionToAsk)
        {
            AllValues = values;
            DataTypes = DataTypes.StringValue;
            QuestionType = QuestionType.YesOrNoQuestion;
        }
    }
}
