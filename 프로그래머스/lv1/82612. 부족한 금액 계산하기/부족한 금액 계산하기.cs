using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long ret = (long)price * count * (count+1)/2;
        ret -= money;
        return ret < 0 ? 0 : ret;
    }
}