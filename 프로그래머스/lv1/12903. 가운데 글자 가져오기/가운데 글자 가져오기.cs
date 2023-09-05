public class Solution {
    public string solution(string s) {
        string answer = "";
        string sSub = "";
        int middle = s.Length / 2;
        if (s.Length % 2 == 0){
            sSub = s.Substring(middle - 1, 2);
            answer = sSub;
        }
        else{
            sSub = s.Substring(middle, 1);
            answer = sSub;
        }
        return answer;
    }
}