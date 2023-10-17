using System;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        int[] countX = new int[10];
        int[] countY = new int[10];
        foreach(char c in X)
            countX[c - '0']++;
        foreach(char c in Y)
            countY[c - '0']++;
        
        StringBuilder result = new StringBuilder();
        
        for(int i = 9; i >= 0; i--){
            int cnt = Math.Min(countX[i], countY[i]);
            for(int j = 0; j < cnt; j++){
                result.Append(i);
            }
        }
        
        if(result.Length == 0)
            return "-1";
        
        if(result.ToString().All(c => c == '0'))
            return "0";
        
        return result.ToString();
    }
}