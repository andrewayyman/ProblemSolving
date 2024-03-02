public class Solution {
    public int RomanToInt(string s)
{
    int num = 0 , ans = 0 ;
    for(int i = s.Length -1; i>=0; i--)
    {
        //assume s = III 
        switch(s[i])   // I
        {
            case 'I': num = 1; break;
            case 'V': num = 5; break;
            case 'X': num = 10; break;
            case 'L': num = 50; break;
            case 'C': num = 100; break;
            case 'D': num = 500; break;
            case 'M': num = 1000; break;
        }  // break with num = 1
        if (4 * num < ans) ans -= num;
        else ans += num;
    }
    return ans;
}
}