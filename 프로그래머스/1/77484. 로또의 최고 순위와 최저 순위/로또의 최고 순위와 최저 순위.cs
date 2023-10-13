using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] rank = {6, 6, 5, 4, 3, 2, 1};

        int minRank = lottos.Count(n => n == 0);
        int maxRank = lottos.Count(n => win_nums.Contains(n));

        return new [] {rank[minRank + maxRank], rank[maxRank]};
    }
}
