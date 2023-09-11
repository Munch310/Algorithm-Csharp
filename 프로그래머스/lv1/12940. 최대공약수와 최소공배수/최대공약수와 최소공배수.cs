public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int OriginN = n;
        int OriginM = m;
        int gcd = 0;
        while(m > 0){
            int temp = n;
            n = m;
            m = temp % m;
            gcd = n;
        }
        answer[0] = gcd;
        answer[1] = OriginN * OriginM / gcd;
        return answer;
    }
}