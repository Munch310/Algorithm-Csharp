using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;

        while (n > 0) {
            int _splitN = n % 10;
            answer += _splitN;
            n /= 10;
        }

        return answer;
    }
}