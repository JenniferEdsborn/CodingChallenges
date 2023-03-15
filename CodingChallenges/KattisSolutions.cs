namespace CodingChallenges;

public class KattisSolutions
{
    void Aaah()
    {
        string jonMarius = Console.ReadLine();
        string doctor = Console.ReadLine();

        if (jonMarius.Length >= doctor.Length)
            Console.WriteLine("go");
        else if (jonMarius.Length < doctor.Length)
            Console.WriteLine("no");
    }

    void AddTwoNumbers()
    {
        string x = Console.ReadLine();
        int[] list = Array.ConvertAll(x.Split(), int.Parse);

        int a = list[0];
        int b = list[1];

        if (a >= 0 && a <= 1000000 && b >= 0 && b <= 1000000)
        {
            Console.WriteLine(a + b);
        }
    }

    void Apaxiaaaaaaaaaaaans()
    {
        string s = Console.ReadLine();

        for (int i = 0; i < s.Length - 1; i++)
        {
            if (s[i] != s[i + 1])
            {
                Console.Write(s[i]);
            }
        }
        Console.Write(s[s.Length - 1]);
    }

    void ColdputerSience()
    {
        int input = int.Parse(Console.ReadLine());
        string[] temps = Console.ReadLine().Split(" ");
        int sum = 0;

        for (int i = 0; i < temps.Length; i++)
        {
            if (int.Parse(temps[i]) < 0)
            {
                sum++;
            }
        }

        Console.WriteLine(sum);
    }

    void CountTheVowels()
    {
        string s = Console.ReadLine().ToLower();
        char[] list = s.ToCharArray();
        int sum = 0;

        foreach (char ch in list)
        {
            if (ch == 'a' || ch == 'o' || ch == 'e' || ch == 'i' || ch == 'u')
                sum++;
        }
        Console.WriteLine(sum);
    }

    void EchoEchoEcho()
    {
        string s = Console.ReadLine();
        Console.WriteLine($"{s} {s} {s}");
    }

    void FYI()
    {
        string number = Console.ReadLine();
        int key = 5;

        if (number[0] == key && number[1] == key && number[2] == key)
            Console.WriteLine("1");
        else
            Console.WriteLine("0");
    }

    void Greetings()
    {
        string greeting = Console.ReadLine();

        int count = greeting.Count(c => c == 'e');
        string hey = "h" + new string('e', count * 2) + "y";

        Console.WriteLine(hey);
    }

    void JobExpenses()
    {
        int n = Int32.Parse(Console.ReadLine());
        int[] k = new int[n];
        int sum = 0;

        if (n >= 0 && n <= 20000)
        {
            string x = Console.ReadLine();
            string[] input = x.Split(" ", n);

            for (int i = 0; i < input.Length; i++)
            {
                k[i] = Int32.Parse(input[i]);

                if (k[i] >= -50000 && k[i] <= 500000 && k[i] != 0)
                {
                    if (k[i] < 0)
                        sum += Math.Abs(k[i]);
                }
            }
        }
        Console.WriteLine(sum);
    }

    void Pot()
    {
        int n = int.Parse(Console.ReadLine());
        int total = 0;

        if (n > 1 && n < 10)
        {
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());

                if (p >= 10 && p <= 9999)
                {
                    int x = (int)Math.Pow(p / 10, p % 10);
                    total = x + total;
                }
            }
            Console.WriteLine(total);
        }
    }

    void SortTwoNumbers()
    {
        string x = Console.ReadLine();
        string[] input = x.Split(" ");
        int[] list = new int[2];

        for (int i = 0; i < input.Length; i++)
        {
            list[i] = Int32.Parse(input[i]);
        }

        int a = list[0];
        int b = list[1];

        if (a >= 0 && a <= 1000000 && b >= 0 && b <= 1000000)
        {
            if (a < b)
                Console.WriteLine(a.ToString() + " " + b.ToString());
            else
                Console.WriteLine(b.ToString() + " " + a.ToString());
        }
    }

    void WhichIsGreater()
    {
        string[] input = Console.ReadLine().Split();
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);

        if (a > 0 && a <= 1e9 && b > 0 && b <= 1e9)
        {
            Console.WriteLine(a > b ? 1 : 0);
        }
    }
}
