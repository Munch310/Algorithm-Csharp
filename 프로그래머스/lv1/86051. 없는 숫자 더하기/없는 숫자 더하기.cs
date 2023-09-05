using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] numbers) {
        int[] compare = {1,2,3,4,5,6,7,8,9,0};
        IEnumerable<int> ret = compare.Except(numbers);
        int answer = 0;
        foreach (int num in ret)
            answer += num;
        return answer;
    }
}
