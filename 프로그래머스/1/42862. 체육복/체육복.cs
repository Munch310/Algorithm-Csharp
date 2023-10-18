using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = n;
        
        var realLost = lost.Except(reserve).OrderBy(x => x).ToArray();
        var realReserve = reserve.Except(lost).OrderBy(x => x).ToList();
        
        foreach(var lostStudent in realLost){
            if(realReserve.Contains(lostStudent - 1)){
                realReserve.Remove(lostStudent - 1);
            }
            else if(realReserve.Contains(lostStudent + 1)){
                realReserve.Remove(lostStudent + 1);
            }
            else{
                answer--;
            }
        }
        return answer;
    }
}