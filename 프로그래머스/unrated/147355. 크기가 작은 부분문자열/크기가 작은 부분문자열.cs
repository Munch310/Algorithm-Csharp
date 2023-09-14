using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long pAsLong = long.Parse(p);
        for(int i = 0; i <= t.Length - p.Length; i++){
            string subString = t.Substring(i, p.Length);
            long subStringAsLong = long.Parse(subString);
            if(subStringAsLong <= pAsLong){
                answer++;
            }
        }
        return answer;
    }
}