using System;

public class Solution {
    public int solution(string s) {
        int count = 0;
        int xCount = 0;
        int notXCount = 0;
        
        char x = s[0];
        
        for (int i = 0; i < s.Length; i++){
            if(s[i] == x)
                xCount++;
            else
                notXCount++;
            
            if(xCount == notXCount)
            {
                count++;
                if(i + 1 < s.Length)
                    x = s[i+1];
                xCount = 0;
                notXCount = 0;
            }
        }
        
        if(xCount != notXCount && (xCount > 0 || notXCount > 0))
            count++;
        
        return count;
    }
}