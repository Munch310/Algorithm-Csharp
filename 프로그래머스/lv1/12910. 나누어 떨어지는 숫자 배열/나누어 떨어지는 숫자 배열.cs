using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> answerList = new List<int>();
        for(int i = 0; i < arr.Length; i++){
            if(arr[i] % divisor == 0){
                answerList.Add(arr[i]);
            }
        }
        answerList.Sort();
        
        int[] answer = answerList.ToArray();
        if(answer.Length == 0){
            answer = new int[] {-1};
        }
        return answer;
    }
}