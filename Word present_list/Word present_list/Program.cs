namespace Word_present_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "chennai", "Mumbai", "kolkatta", "delhi", "bangalore" };
            Array.Sort(words);

            Console.WriteLine("Enter a word to search:");
            string searchWord = Console.ReadLine();

            bool found = Array.BinarySearch(words, searchWord) >= 0;
            if (found)
            {
                Console.WriteLine("The word is present in the list.");
            }
            else
            {
                Console.WriteLine("The word is not present in the list.");

            }
        }
    }
}