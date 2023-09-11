using System;
using System.Linq;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string num = Base10ToBase3(n);
        string reverseNum = new string(num.Reverse().ToArray());
        for (int i = 0; i < reverseNum.Length; i++)
        {
           int digit = int.Parse(reverseNum[i].ToString());
           answer += digit * (int)Math.Pow(3, reverseNum.Length - 1 - i);
        }
        return answer;
    }
    
    public string Base10ToBase3(int n){
        int m = 3;
        string num = "";
        while(n > 0){
            int temp = n % m;
            num = temp.ToString() + num;
            n = n / m;
        }
        return num;
    }
}