using System;

public class Solution {
    public int solution(int n) {
        int _n = n;
        int answer = 0;

        while (_n > 0) {
            int _splitN = _n % 10;
            answer += _splitN;
            _n /= 10;
        }

        return answer;
    }
}