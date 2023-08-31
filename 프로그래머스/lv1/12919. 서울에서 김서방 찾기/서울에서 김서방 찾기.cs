using System;
public class Solution {
    public string solution(string[] seoul) {
        int indexKim = Array.IndexOf(seoul, "Kim");
        string answer = $"김서방은 {indexKim}에 있다";
        return answer;
    }
}