namespace CodingChallenges;

public class LeetCodeSolutions
{
    int[] TwoSum(int[] arr, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < arr.Length; i++)
        {
            int complement = target - arr[i];
            if (dict.ContainsKey(complement))
            {
                return new int[] { dict[complement], i };
            }
            dict[arr[i]] = i;
        }
        return null;
    }

    bool IsPalindrome(int x)
    {
        char[] arr = x.ToString().ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        int reversedInt;
        if (Int32.TryParse(reversed, out reversedInt) && x == reversedInt)
        {
            return true;
        }
        return false;
    }

    int RomanToInt(string s)
    {
        var dict = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

        char[] arr = s.ToCharArray();
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int value = dict[s[i]];
            if (i < s.Length - 1 && value < dict[s[i + 1]])
            {
                sum -= value;
            }
            else
            {
                sum += value;
            }
        }

        return sum;
    }
}
