namespace ArrayListExerciseTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your name");
            var userName = Console.ReadLine();
            var nameArray = userName.ToCharArray();
            var reverseNameArray = nameArray.Reverse();
            string reverseName = string.Join("", reverseNameArray);
            Console.WriteLine(string.Format("Your name spelled backwards is: {0}.", reverseName));
        }
    }
}