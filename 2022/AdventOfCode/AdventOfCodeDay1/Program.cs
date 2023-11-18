namespace AdventOfCodeDay1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Day 1
            Day1Service findTheElf = new Day1Service();
            Console.WriteLine(findTheElf.FindTheStrongestElf());
        }
    }
}