using System.Collections;
using Day15HashTable;

class Program
{
    MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
    public void Frequency(string str)
    {

        // Split the string by spaces
        string[] a = str.Split(' ');
        for (int j = 0; j < a.Length; j++)
        {
            string word = a[j];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (word.Equals(a[i]))
                    count++;
            }
            Console.WriteLine($"The frequency of \"{a[j]}\" is \"{count}\"");
            hash.Add($"{j}", word);
            Console.WriteLine($"Key - \"{j}\" Value - \"{hash.Get($"{j}")}\"");
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to HashTable and Binary search Tree programs");
        string str = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
        Program p = new Program();
        p.Frequency(str);
        Console.WriteLine("Enter any index from 0 to 5 to find the value");
        int j = Convert.ToInt32(Console.ReadLine());
        string n = p.hash.Get($"{j}");
        Console.WriteLine($"\nIndex {j}'s value: {n}");
    }
}