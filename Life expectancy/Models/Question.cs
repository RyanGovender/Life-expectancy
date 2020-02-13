using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.Models
{
    public enum DataTypes
    {
        Integer = 0,
        StringValue = 1,
    }

    public enum QuestionType
    {
        ValueQuestion = 0,
        YesOrNoQuestion =1,
        MultipleQuestion =2
    }
    public class Question
    {
        public int Id { get; set; }
        public string QuestionToAsk { get; set; }

        public DataTypes DataTypes { get;set; }

        public QuestionType QuestionType { get; set; }

        public List<double> AllValues { get; set; }

        public Question(int id, string questionToAsk)
        {
            Id = id;
            QuestionToAsk = questionToAsk;
        }
    }
}
