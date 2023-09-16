public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        char[] charArray = s.ToCharArray();
        
        for(int i = 0; i < charArray.Length; i++){
            if(char.IsLetter(charArray[i])){
                char baseChar = char.IsUpper(charArray[i]) ? 'A' : 'a';
                charArray[i] = (char)(((charArray[i] - baseChar + n) % 26) + baseChar);
            }
        }
        return new string(charArray);
    }
}