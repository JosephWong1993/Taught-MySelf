//间接引用数组的例子
#include<iostream>
using namespace std;
typedef double array_[10];
void main() {
	array_ a = { 12,34,56,78,90,98,76,85,64,43 };
	array_& b = a;
	a[2] = 100;						//操作数组
	for (int i = 0; i < 10; i++)	//数组 b 与数组 a 同步变化
		cout << b[i] << " ";
}