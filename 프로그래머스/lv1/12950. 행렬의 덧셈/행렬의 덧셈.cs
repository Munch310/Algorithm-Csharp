public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int answerRow = arr1.GetLength(0);
        int answerCol = arr1.GetLength(1);
        int[,] answer = new int[answerRow, answerCol];
        for(int i = 0; i < answerRow; i ++){
            for(int j = 0; j < answerCol; j ++){
                answer[i,j] = arr1[i,j] + arr2[i,j];
            }
        }
        return answer;
    }
}