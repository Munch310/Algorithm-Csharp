using System;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        foreach (char c in s) {
            char temp = c;
            int shift = 0;

            while (shift < index) {
                temp = (char)((temp - 'a' + 1) % 26 + 'a'); // 알파벳을 순환
                if (!skip.Contains(temp)) {
                    shift++; // skip에 포함되지 않은 경우에만 shift 증가
                }
            }

            answer += temp;
        }
        
        return answer;
    }
}
