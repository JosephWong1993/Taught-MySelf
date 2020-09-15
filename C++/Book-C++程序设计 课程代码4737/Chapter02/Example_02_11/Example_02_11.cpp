/* 演示string对象的例子 */
#include<iostream>
#include<string>
#include<algorithm>
using namespace std;
void main() {
	string str1 = "we are here!", str2 = str1;
	reverse(&str1[0], &str1[0] + 12);										//str1字符串的元素逆向
	cout << str1 << endl;													//输出逆向后的内容
	copy(&str1[0], &str1[0] + 12, &str2[0]);								//原样复制到str2
	cout << str2 << endl;													//输出str2
	reverse_copy(&str2[0], &str2[0] + 12, ostream_iterator<char>(cout));	//逆向输出str2
}