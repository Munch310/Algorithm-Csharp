using System;
public class Solution {
    public long solution(int a, int b) {
        int start = Math.Min(a, b);
        int end = Math.Max(a, b);
        long answer = 0;
        for (int i = start; i <= end; i++) {
            answer += i;
        }
        return answer;
    }
}