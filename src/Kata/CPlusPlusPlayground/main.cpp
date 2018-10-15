#include <iostream>
#include "StringExtensions.h"


int main() {
	string targetString = "This is some text. You can find indices in it.";

	cout << targetString << endl;

	cout << "Enter text to find indice of: ";
	
	char stringToFind[256];
	cin.getline(stringToFind, 256);

	int outIndex = indexOf(stringToFind, targetString);

	cout << "Your text '" << stringToFind << "' appears at index " << outIndex;
	
	cin.ignore();

	return 0;
}


void ReverseSubroutine() {

	cout << "Enter some text: ";

	char reverseMe[256];
	cin.getline(reverseMe, 256);

	string outString = reverseString(reverseMe);
	cout << outString << endl;
}