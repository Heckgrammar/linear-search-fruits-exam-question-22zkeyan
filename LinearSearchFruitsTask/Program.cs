namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static bool Linear_search(string[] list_data, string search_key) //initialises the linear search algorithm with two parameters
        {
            int index = 0; //sets index to 0 (start of algorithm)
            while (index < list_data.Length && list_data[index] != search_key) //checks if the index hasn't exceeded the length of the array and the search key hasn't been found (if the element at the index is less than the search key)
            {
                index++; //changes index by 1
            }
            if (index >= list_data.Length || list_data[index] != search_key) //checks if the index has exceeded the length of the array and the search key hasn't been found
            {
                return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
            Console.Write("Enter word to find: ");
            string word = Console.ReadLine()!;
            bool in_list = Linear_search(fruits, word);
            if (in_list)
            {
                Console.WriteLine($"{word} is in the list");
            }
            else
            {
                Console.WriteLine($"{word} isn't in the list");
            }
        }
    }
}
