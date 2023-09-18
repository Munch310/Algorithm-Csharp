using System;
using System.Text.RegularExpressions;

public class Solution {
    public int solution(string s) {
        string str = Regex.Replace(s, "one", "1").Replace("two", "2").Replace("three", "3").Replace("four", "4").Replace("five", "5").Replace("six", "6").Replace("seven", "7").Replace("eight", "8").Replace("nine", "9").Replace("zero", "0");
        
        int answer = int.Parse(str);
        
        return answer;
    }
}
