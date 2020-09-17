/* 函数返回对象的例子 */
#include<iostream>
#include<string>
using namespace std;
string input(const int);				//声明返回string类型的函数
void main() {
	int n;
	cout << "Input n = ";
	cin >> n;							//接收要处理的字符串数量
	string str = input(n);				//将函数返回的对象赋给对象str
	cout << str << endl;
}
string input(const int n) {
	string s1, s2;						//建立两个string类的对象（均为空串）
	for (int i = 0; i < n; i++)			//接收n个字符串
	{
		cin >> s1; s2 = s2 + s1 + " ";	//将接收的字符串相加
	}
	return s2;							//返回string对象
}