namespace ConsoleApp9;

public class Program
{
    static int Convert(string roman)
    {
        Dictionary<char, int> map = new Dictionary<char, int>(){
            {'I', 1 },
            {'V', 5 },
            {'X', 10 },
            {'L', 50 },
            {'C', 100 },
            {'D', 500 },
            {'M', 1000 }
        };
        int result = 0;
        for (int i = 0; i < roman.Length; i++)
        {
            if (i + 1 < roman.Length && map[roman[i]] < map[roman[i + 1]])
            {
                result -= map[roman[i]];
            }
            else
            {
                result += map[roman[i]];
            }
        }
        return result;
    }
    static void Main(string[] args)
    {
        int arabicNumber;
        Console.Write("Enter roman number: ");
        string roman = Console.ReadLine();
        arabicNumber = Convert(roman);
        Console.WriteLine("Arabic number - " + arabicNumber);
    }
}