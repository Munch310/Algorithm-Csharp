public class Solution {
    public string solution(int n) {
        string answer = "";
        char[] watermelon = {'수', '박'};
        
        for (int i = 0; i < n; i++) {
            answer += watermelon[i % 2];
        }
        
        return answer;
    }
}