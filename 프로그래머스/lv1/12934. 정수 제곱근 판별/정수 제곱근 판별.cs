using System;

public class Solution {
    public long solution(long n) {
        var retN = Math.Ceiling(Math.Sqrt(n));
        long answer = 0;
        if(n / retN == retN){ 
            answer = (long)Math.Pow((retN + 1), 2);
        }
        else{
            answer = -1;
        }
        return answer;
    }
}