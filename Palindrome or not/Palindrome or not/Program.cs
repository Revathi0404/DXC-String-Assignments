namespace Palindrome_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "level", "madam", "hii", "wise", "mom" };
            int count = 0;

            Console.WriteLine("The list of words: ");

            foreach (string word in words)
            {
                bool isPalindrome = true;

                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - i - 1])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome)
                {
                    Console.WriteLine("{0} is a palindrome!", word);
                    count++;
                }
            }

            Console.WriteLine("The number of palindromes in the list: {0}", count);

            Console.ReadLine();

        }
    }
}