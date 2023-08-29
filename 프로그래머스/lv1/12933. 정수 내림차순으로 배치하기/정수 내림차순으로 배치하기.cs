using System;
public class Solution {
    public long solution(long n) {
        long answer = 0;
        char[] arrayN = n.ToString().ToCharArray();
        Array.Sort(arrayN);
        Array.Reverse(arrayN);
        answer = long.Parse(arrayN);
        return answer;
    }
}