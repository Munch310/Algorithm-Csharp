public class Solution {
    public int solution(int num) {
        int answer = 0;
        int count = 0;
        while(num != 1){
            if(num % 2 == 0){
                num /= 2;
                count++;
            }
            else if(num % 2 == 1){
                num = (num * 3) + 1;
                count++;
            } 
            else if(count > 500 || num < 0){
                count = -1;
                break;
            }
        }
        answer = count;
        return answer;
    }
}