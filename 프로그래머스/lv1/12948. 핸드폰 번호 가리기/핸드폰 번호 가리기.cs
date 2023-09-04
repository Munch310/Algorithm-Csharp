public class Solution {
    public string solution(string phone_number) {
        int num = 4;
        int length = phone_number.Length;
        string replaceStr = new string('*', length - num) + phone_number.Substring(length - num);
        return replaceStr;
    }
}