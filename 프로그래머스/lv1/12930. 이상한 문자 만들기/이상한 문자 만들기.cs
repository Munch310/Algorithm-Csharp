using System;

public class Solution {
    public string solution(string s) {
        string[] answerArray = s.Split(new char[] { ' ' }, StringSplitOptions.None);
        
        for(int i = 0; i < answerArray.Length; i++) {
            for(int j = 0; j < answerArray[i].Length; j++) {
                if(j % 2 == 0) {
                    answerArray[i] = answerArray[i].Substring(0, j) + char.ToUpper(answerArray[i][j]) 
                        + answerArray[i].Substring(j + 1);
                }
                else if(j % 2 == 1){
                    answerArray[i] = answerArray[i].Substring(0,j) + char.ToLower(answerArray[i][j]) 
                        + answerArray[i].Substring(j + 1);
                }
            }
        }
        
        string answer = string.Join(" ", answerArray);
        return answer;
    }
}