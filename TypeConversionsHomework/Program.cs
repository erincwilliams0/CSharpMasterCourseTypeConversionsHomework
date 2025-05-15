namespace TypeConversionsHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // capture the users age 
            Console.Write("Please enter your age using numeric characters: ");
            // validate the users age
            string? ageString = Console.ReadLine().Trim();
            //	make sure a number was provided
            if (!int.TryParse(ageString, out int age))
            {
                Console.WriteLine("Something went wrong, please enter your age, just the numbers");
                Console.ReadLine();
                return;
            }
            //	make sure they are a realistic age 1 through 110
            if(age < 1 || age > 110)
            {
                Console.WriteLine("uh huh, are you sure about that?");
                Console.ReadLine();
                return;
            }
            // store the users age in 25 years
            // store what the users age would have been 25 years ago, negatives are acceptable
            int agePlus25 = age + 25;
            int ageMinus25 = age - 25;

            // print out message in the format... you would be ... inn 25 years, and 25 years ago you were ...
            Console.WriteLine($"you would be {agePlus25} in 25 years, and 25 years ago you would have been {ageMinus25} years old!");
            Console.ReadLine();
        }
    }
}
