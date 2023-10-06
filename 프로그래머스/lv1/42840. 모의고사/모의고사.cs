using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        List<int> answer = new List<int>();
        int[] num1 = new int[5] {1,2,3,4,5};
        int[] num2 = new int[8] {2,1,2,3,2,4,2,5};
        int[] num3 = new int[10] {3,3,1,1,2,2,4,4,5,5};
        int count1 = 0;
        int count2 = 0;
        int count3 = 0;
        
        for(int i = 0; i < answers.Length; i++){
            if(answers[i] == num1[i % num1.Length]){
                count1++;
            }
            if(answers[i] == num2[i % num2.Length]){
                count2++;
            }
            if(answers[i] == num3[i % num3.Length]){
                count3++;
            }
        }
        
        Dictionary<int,int> counts=new Dictionary<int,int>(){
            {1,count1},
            {2,count2},
            {3,count3}
          };
          
          var maxCount=counts.Values.Max();
          
          foreach (var item in counts)
          {
              if (item.Value == maxCount)
              {
                  answer.Add(item.Key);
              }
           }

           return answer.ToArray();
       }
}