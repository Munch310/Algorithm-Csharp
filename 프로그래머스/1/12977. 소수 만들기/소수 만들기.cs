using System;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        for(int i = 0; i < nums.Length - 2; i++){
            for(int j = i + 1; j < nums.Length - 1; j++){
                for(int k = j + 1; k < nums.Length; k++){
                    int sum = nums[i] + nums[j] + nums[k];
                    bool isPrime = true;
                    if(sum <= 1){
                        isPrime = false;
                    }
                    else{
                        for(int p = 2, sq=(int)Math.Sqrt(sum); p<=sq; ++p){
                            if(sum % p == 0){
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    if(isPrime){
                        answer++;
                    }
                }
            }
            
        }

        System.Console.WriteLine(answer);

        return answer;
    }
}