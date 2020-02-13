using System;
using System.Collections.Generic;
using System.Text;

namespace Life_expectancy.Models
{
    public class MultipleChoiceQuestion : Question
    {
        public List<string> MultipleChoice { get; set; }
        public MultipleChoiceQuestion(int id, string questionToAsk, List<string> multiplechoice) : base(id, questionToAsk)
        {
            MultipleChoice = multiplechoice;
            DataTypes = DataTypes.Integer;
            QuestionType = QuestionType.MultipleQuestion;
        }
    }
}
