#include "Sum.h"
#include<iostream>
using namespace std;
void main() {
	Sum<int, 4> num1(-23, 5, 8, -2);			//整数求和
	Sum<float, 4>f1(3.5f, -8.5f, 8.8f, 9.7f);	//单精度求和，使用f显式说明float类型
	Sum<double, 4>d1(355.4, 253.8, 456.7, -67.8);
	Sum<char, 4>c1('W', -2, -1, -1);			//字符减，等效于'W'-4，结果为'S'
	cout << num1.S() << " ," << f1.S() << " ," << d1.S() << " , " << c1.S() << endl;
}