using System;
using System.Linq;
using System.Collections.Generic;
public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        Dictionary<char, int> values = new Dictionary<char, int>();
        for(int i= 0; i < s.Length; i++){
            char currentChar = s[i];
            if(values.ContainsKey(currentChar)){
                int index = values[currentChar];
                answer[i] = i - index;
            }
            else{
                answer[i] = -1;
            }
            values[currentChar] = i;
        }
        return answer;
    }
}
