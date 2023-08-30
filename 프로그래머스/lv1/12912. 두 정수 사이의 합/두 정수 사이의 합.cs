using System;

public class Solution {
    public long solution(int a, int b) {
        long answer = 0;
        long ret = 0;
        long longA = Convert.ToInt64(a);
        long longB = Convert.ToInt64(b);
        
        if(longA > longB){
            for(long i = longB; i <= longA; i++){
                ret += i;
            }
            answer = ret;
        }else if (longA == longB){
            answer = longA;
        }
        else{
            for(long i = longA; i<= longB; i++){
                ret += i;
            }
            answer = ret;
        }
        return answer;
    }
}