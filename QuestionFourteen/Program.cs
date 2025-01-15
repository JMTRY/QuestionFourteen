using QuestionFourteen.Helper;

namespace QuestionFourteen
{
    public class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => GenerateNumbers.GenerateRandomNumber())
                .ContinueWith(task =>
                {
                    return Format(task.Result);
                })
                .ContinueWith(task =>
                {
                    Console.WriteLine(task.Result);
                });

            Console.ReadLine();
        }


        public static string Format(int number)
        {
            return $"The Generated Number is: {number}";
        }
    }
}


