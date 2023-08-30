public class Solution {
    public bool solution(int x) {
        int originX = x;
        int sum = 0;
        bool answer = false;
        do{
            sum += x % 10;
            x /= 10; 
        }while(x>0);
        if(originX % sum == 0)
            answer = true;
        return answer;
    }
}