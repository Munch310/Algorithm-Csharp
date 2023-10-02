using System;
public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        DateTime dateValue = new DateTime(2016, a , b);
        answer = dateValue.ToString("ddd").ToUpper();
        return answer;
    }
}