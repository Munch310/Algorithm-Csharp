public class Solution {
    public int[] solution(long n) {
        string strN = n.ToString();
        int strNLength = strN.Length;
        int[] answer = new int[strNLength];
        
        for (int i = 0; i < strNLength; i++){
            char charN = strN[strNLength - i - 1];
            int result = int.Parse(charN.ToString());
            answer[i] = result;
        }
        
        return answer;
    }
}