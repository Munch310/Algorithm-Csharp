using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        for(int i = 1; i <= number; i++){
            int divisors = CountDivisors(i);
            if(divisors > limit){
                answer += power;
            }
            else{
                answer += divisors;
            }
        }
        return answer;
    }
    
    private int CountDivisors(int n){
        int count = 0;
        for(int i = 1; i * i <= n; i++){
            if(n % i == 0){
                if(i * i == n){
                    count++;
                }
                else{
                    count += 2;
                }
            }
        }
        return count;
    }
}
