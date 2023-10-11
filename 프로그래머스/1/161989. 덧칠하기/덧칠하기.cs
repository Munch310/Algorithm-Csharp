using System;
using System.Linq;

public class Solution {
    public int solution(int n, int m, int[] section) {
        Array.Sort(section);
        int answer = 0;
        int i = 0;
        
        while (i < section.Length){
            int end = section[i] + m - 1;
            
            while(i < section.Length && section[i] <= end){
                i++;
            }
            answer++;
        }
        return answer;
    }
}