class Program
{
    static void Main()
    {
        
        char[] charArray = new char[20];

        Console.WriteLine("Введите 20 символов (строчные буквы и пробелы):");
        string input = Console.ReadLine();

       
        if (input.Length != 20)
        {
            Console.WriteLine("Ошибка: необходимо ввести ровно 20 символов.");
            return;
        }

        for (int i = 0; i < 20; i++)
        {
            charArray[i] = input[i];
        }

        string inputString = new string(charArray);

        string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        Console.WriteLine("Слова, начинающиеся и заканчивающиеся на одну и ту же букву:");

        foreach (string word in words)
        {
            if (word.Length > 0 && word[0] == word[word.Length - 1])
            {
                Console.WriteLine(word);
            }
        }
    }
}
