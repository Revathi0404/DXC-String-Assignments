namespace Sort_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Mumbai", "Chennai", "Kolkatta", "Bangalore", "Delhi" };

            Console.WriteLine("The original array is:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Array.Sort(words);

            Console.WriteLine("\nThe sorted array is:");
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);

            }
        }
    }
}