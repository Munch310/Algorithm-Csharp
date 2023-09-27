using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> honor= new List<int>();
        for(int i = 0; i < score.Length; i++)
        {
            if(honor.Count == k)
            {
                if(honor[0] > score[i])
                {
                    answer[i] = honor[0];
                    continue;
                }
                honor.RemoveAt(0);
            }
            honor.Add(score[i]);
            honor.Sort();
            answer[i] = honor[0];
        }
        return answer;
    }
}