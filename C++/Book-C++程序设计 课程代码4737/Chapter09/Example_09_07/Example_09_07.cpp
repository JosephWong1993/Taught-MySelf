/* 演示使用标志位的例子 */
#include<iostream>
using namespace std;
const double PI = 3.141592;
void main() {
	int a = 15;
	bool it = 1, not_ = 0;
	cout << showpoint << 123.0 << " "	//输出小数位
		<< noshowpoint << 123.0 << " ";	//不输出小数位
	cout << showbase;					//演示输出数基
	cout << a << " " << uppercase << hex << a << " " << nouppercase	//演示大小写
		<< hex << a << " " << noshowbase << a << dec << a << endl;
	cout << uppercase << scientific << PI << " " << nouppercase << PI << " " << fixed << PI << endl;
	cout << cout.precision() << " " << PI << " ";					//演示cout的成员函数
	cout.precision(4);
	cout << cout.precision() << " " << PI << endl;
	cout.width(10);
	cout << showpos << right << a << " " << noshowpos << PI << " ";	//演示数值符号
	cout << it << " " << not_ << " "								//演示bool
		<< boolalpha << it << " " << " " << not_ << " "
		<< noboolalpha << " " << it << " " << not_ << endl;
	cout.width(10);
	cout << left << PI << " " << 123 << " " << cout.width() << " ";
	cout << 123 << " " << cout.width() << endl;
}