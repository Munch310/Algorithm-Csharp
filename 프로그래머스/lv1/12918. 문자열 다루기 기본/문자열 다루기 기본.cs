using System.Text.RegularExpressions;
public class Solution {
    public bool solution(string s) {
        bool IsNum = Regex.IsMatch(s, "^[0-9]+$");
        // 문자열이 4 or 6이고, 숫자로만 구성되어있으면 true 
        if((s.Length == 4 || s.Length == 6) && IsNum){
            return true;
        }
        else{
            return false;
        }  
    }
}