#include <string>
#include <vector>

using namespace std;

string solution(string s, string skip, int index) {
    string answer = "";
    
    for (char c : s) {
        char temp = c;
        int shift = 0;

        while (shift < index) {
            temp = (char)((temp - 'a' + 1) % 26 + 'a'); // 알파벳을 순환
            if (skip.find(temp) == string::npos) { // skip에 포함되지 않으면
                shift++;
            }
        }

        answer += temp;
    }
    
    return answer;
}
