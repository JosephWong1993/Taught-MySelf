//函数重载产生多态性的例子
#include <iostream>
using namespace std;
int max(int, int);		//2个整数参数的函数原型
int max(int, int, int);	//3个整数参数的函数原型
void main() {
	cout << max(35, 25) << "，" << max(25, 39, 35) << endl;
}
int max(int m1, int m2) {
	return(m1 > m2) ? m1 : m2;
}
int max(int m1, int m2, int m3) {
	int t = max(m1, m2);
	return max(t, m3);
}