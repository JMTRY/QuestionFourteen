namespace QuestionFourteen.Helper
{
    public class GenerateNumbers
    {
        public static int GenerateRandomNumber()
        {
            Func<int> randomNumberFunc = () =>
            {
                Random rand = new Random();
                return rand.Next(1, 10001);
            };

            return randomNumberFunc();
        }
    }
}
