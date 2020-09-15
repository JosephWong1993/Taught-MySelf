/* 演示使用string对象及初始化的例子 */
#include<iostream>
#include<string>
using namespace std;
void main() {
	string str1("We are here!");
	string str2 = "Where are you?";
	cout << str1[0] << str1[11] << "," << str1 << endl;
	cout << str2[0] << str2[13] << "," << str2 << endl;
	cout << "please input a work:";
	cin >> str1;
	cout << "length of the " << str1 << " is " << str1.size() << "." << endl;
}