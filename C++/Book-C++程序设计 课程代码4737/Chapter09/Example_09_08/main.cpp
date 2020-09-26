/* 使用成员函数设置标志位的例子 */
#include<iostream>
using namespace std;
const double PI = 3.141592;
void main() {
	int a = 15;
	cout.setf(ios_base::showpoint);	//演示使用setf和unsetf
	cout << 123.0 << " ";
	cout.unsetf(ios_base::showpoint);
	cout << 123.0 << endl;
	cout.setf(ios_base::showbase);
	cout.setf(ios_base::hex, ios_base::basefield);
	cout << a << " " << uppercase << hex << a << " " << nouppercase	//比较哪种方便
		<< hex << a << " " << noshowbase << a << dec << " " << a << endl;
	float c = 23.56F, d = -101.22F;
	cout.width(20);
	cout.setf(ios_base::scientific | ios_base::right | ios_base::showpos, ios::floatfield);
	cout << c << "\t" << d << "\t";
	cout.setf(ios_base::fixed | ios_base::showpos, ios_base::floatfield);
	cout << c << "\t" << d << endl;
	cout << cout.flags() << " " << 123.0 << " ";	//演示输出flags
	cout.flags(513);								//演示设置flags
	cout << 123.0 << endl;
	cout.setf(ios_base::scientific);				//演示省略方式
	cout << 123.0 << endl;
	cout.width(8);									//设置填充字符数量(n-1)
	cout << cout.fill('*') << 123 << endl;			//演示填充
}