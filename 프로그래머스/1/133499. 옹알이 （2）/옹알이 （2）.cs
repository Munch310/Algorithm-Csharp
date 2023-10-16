using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] possible = new string[4] {"aya", "ye", "woo", "ma"};
        
        foreach (string word in babbling){
            string temp = word;
            string lastSound = "";
            
            while (temp.Length > 0){
                string currentSound = "";
                
                foreach (string pos in possible){
                    if (temp.StartsWith(pos) && pos != lastSound){
                        currentSound = pos;
                        break;
                    }
                }
                
                if (currentSound == ""){
                    break;
                }
                
                temp = temp.Substring(currentSound.Length);
                lastSound = currentSound;
            }
            
            if(temp.Length == 0){
                answer++;
            }
        }
        return answer;
    }
}