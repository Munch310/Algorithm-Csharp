using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>();
        int[][] patterns = new int[3][]{
            new int[] {1,2,3,4,5},
            new int[] {2,1,2,3,2,4,2,5},
            new int[] {3,3,1,1,2,2,4,4,5,5}
        };
        int[] counts = new int[3];
        
        for(int i = 0; i < answers.Length; i++){
            for(int j = 0; j< patterns.Length; j++){
                if(answers[i] == patterns[j][i % patterns[j].Length]){
                    counts[j]++;
                }
            }
        }
        
        Dictionary<int, int> countsDic = new Dictionary<int, int>();
        
        for(int i = 0; i< counts.Length; i++){
            countsDic.Add(i + 1, counts[i]);
        }
        
        var maxCount = countsDic.Values.Max();
        
        foreach(var item in countsDic){
            if(item.Value == maxCount){
                answer.Add(item.Key);
            }
        }
        return answer.ToArray();
    }
}
