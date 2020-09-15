/* 演示string对象数组的例子 */
#include<iostream>
#include<string>
#include<algorithm>
using namespace std;
void main() {
	string str[] = { "We are here!","Where are you?","welcome!" };
	for (int i = 0; i < 3; i++)
	{
		copy(str[i].begin(), str[i].end(), ostream_iterator<char>(cout));
		cout << endl;
	}
	str[0].swap(str[2]);
	str[0].swap(str[1]);
	for (int i = 0; i < 3; i++)
	{
		cout << str[i] << endl;
	}
}