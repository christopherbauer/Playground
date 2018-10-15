#include <string>
using namespace std;

string reverseString(string theString) {
	string reversedString = "";
	for (int i = theString.length(); i > 0; i--){
		reversedString += theString[i - 1];
	}
	return reversedString;
}
int indexOf(string theString, string inString) {
	int stringLength = theString.length();
	for (int i = 0; i < inString.length() - (stringLength-1); i++) {
		if (inString.substr(i, stringLength) == theString) {
			return i;
		}
	}
	return -1;
}