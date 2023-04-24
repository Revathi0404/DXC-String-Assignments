namespace Shortest_word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of words:");
            int numWords = Convert.ToInt32(Console.ReadLine());

           
            string[] words = new string[numWords];

            
            Console.WriteLine("Enter the words:");
            for (int i = 0; i < numWords; i++)
            {
                words[i] = Console.ReadLine();
            }

         
            string shortestWord = words[0];
            for (int i = 1; i < numWords; i++)
            {
                if (words[i].Length < shortestWord.Length)
                {
                    shortestWord = words[i];
                }
            }

            
            Console.WriteLine("The shortest word is " + shortestWord + ".");

        }
    }
}