/* 演示双向访问的例子 */
#include<iostream>
#include<vector>
using namespace std;
void main() {
	char st[11] = "abcdefghij";
	vector<char> a(st, st + 10);
	vector<char>::iterator p = a.begin();			//定义正向泛型指针并初始化
	vector<char>::reverse_iterator ps;				//定义逆向泛型指针
	for (p = a.begin(); p != a.end(); ++p)			//正向访问
	{
		cout << *p << " ";							//输出a b c d e f g h i j
	}
	cout << endl;
	for (p = a.end() - 1; p != a.begin(); --p) {	//使用正向泛型逆向访问
		cout << *p << " ";							//输出j i h g f e d c b
	}
	cout << endl;
	for (ps = a.rbegin(); ps != a.rend(); ++ps)		//使用逆向泛型指针正向访问，运用++运算
	{
		cout << *ps << " ";							//输出 j i g f e d c b a
	}
	cout << endl;
	for (--ps; ps != a.rbegin(); --ps)				//使用逆向泛型指针逆向访问，运用--运算
	{
		cout << *ps << " ";							//输出 a b c d e f g h i
	}
}