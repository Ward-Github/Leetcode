public class Solution {
    public bool IsPalindrome(int x) {
        
        string y = x.ToString();
        bool isPalin = true;
        
        for (int i = y.Length - 1; i >= 0; i--)
        {
            if (y[i] != y[y.Length - 1 - i])
            {
                isPalin = false;
                break;
            }
        }

        return isPalin;
    }
}
