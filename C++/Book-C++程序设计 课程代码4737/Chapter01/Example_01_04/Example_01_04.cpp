//演示引用的例子
#include <iostream>
using namespace std;
void main() {
	int x = 56;	//定义并初始化 x
	int& a = x;	//声明 a 是 x 的引用，a 和 x 的地址相同
	int& r = a;	//声明 r 是 a 的引用，r 和 a 的地址相同，即和 x 的地址也相同
	cout << "x = " << x << ",&x = " << &x << ",a = " << a << ",&a = " << &a
		<< ",r = " << r << ",&r = " << &r << endl;
	r = 25;		//改变 r，则 a 和 x 都同步变化
	cout << "x = " << x << ",&x = " << &x << ",a = " << a << ",&a = " << &a
		<< ",r = " << r << ",&r = " << &r << endl;
}