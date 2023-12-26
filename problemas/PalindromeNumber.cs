public class Solution {
    public bool IsPalindrome(int x) {
    int original = x;
    int resto=0;
    int reverso=0;
    do
    {
        if(original < 0){ return false;}
        resto = x % 10;
        x /= 10;
        reverso = resto + reverso*10;    

        if (reverso == original)
        {
            return true;
        }
    } while (x != 0);
        return false;
    }
}