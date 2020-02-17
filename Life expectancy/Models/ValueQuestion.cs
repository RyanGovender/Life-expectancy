namespace Life_expectancy.Models
{
    public class ValueQuestion : Question
    {
        public double Value { get; }
        public ValueQuestion(int id, string questionToAsk,double value) : base(id, questionToAsk)
        {
            Value = value;
            DataTypes = DataTypes.Integer;
            QuestionType = QuestionType.ValueQuestion;
        }
    }
}
