
namespace IndividualMarkOfPerson
{
   public class Program 
    {
        public static void Main()
        {
            var _service = new StudentResult();

            Console.WriteLine("Please enter the name of subject 1");
            var subject1 = Console.ReadLine();

            Console.WriteLine($"Please enter the percentage for {subject1} ");
            var percentage = Convert.ToInt32(Console.ReadLine());

            _service.AddMark(new StudentMark
            {
                Percentage = percentage,
                Subject = subject1

            });

            Console.WriteLine("Please enter the name of subject 1");
            var subject2 = Console.ReadLine();

            Console.WriteLine($"Please enter the percentage for {subject2} ");
            var percentage2 = Convert.ToInt32(Console.ReadLine());

            _service.AddMark(new StudentMark
            {
                Percentage = percentage2,
                Subject = subject2

            });

            Console.WriteLine("Please enter the name of subject 1");
            var subject3 = Console.ReadLine();

            Console.WriteLine($"Please enter the percentage for {subject3} ");
            var percentage3 = Convert.ToInt32(Console.ReadLine());

            _service.AddMark(new StudentMark
            {
                Percentage = percentage3,
                Subject = subject3

            });
            var average = _service.OverallPercentage();
         
            Console.WriteLine($"Congradulations, you have passed with an average of {average}");

            var passOrFail = _service.PassOrFail();
            if (passOrFail == true)
            {
                Console.WriteLine($" Congratulations, you have passed with an average of {average}.");
            }
            else
            {

                Console.WriteLine($" Bad luck, you have failed with an average of {average}.");
            }
              
            var lowestPercentage = _service.WorstPercentage();
            var bestSubject = _service.BestSubject();
            Console.WriteLine($"Your best subejct was {bestSubject} , and your worst percentage was {lowestPercentage}.");
        }
    }
}