namespace Milionerzy.Core
{
    public static class EnumExtensions
    {
        public static string ToNumber(this QuestionNumber questionNumber)
        {
            switch(questionNumber)
            {
                case QuestionNumber.Pytanie_1:
                    return "1. ";
                case QuestionNumber.Pytanie_2:
                    return "2. ";
                case QuestionNumber.Pytanie_3:
                    return "3. ";
                case QuestionNumber.Pytanie_4:
                    return "4. ";
                case QuestionNumber.Pytanie_5:
                    return "5. ";
                case QuestionNumber.Pytanie_6:
                    return "6. ";
                case QuestionNumber.Pytanie_7:
                    return "7. ";
                case QuestionNumber.Pytanie_8:
                    return "8. ";
                case QuestionNumber.Pytanie_9:
                    return "9. ";
                case QuestionNumber.Pytanie_10:
                    return "10. ";
                default:
                    return "Następne pytanie: ";
            }
        }
    }
}
