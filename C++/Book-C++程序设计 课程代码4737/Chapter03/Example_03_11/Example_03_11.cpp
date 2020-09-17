/* 函数返回值作为函数的参数 */
#include<iostream>
using namespace std;
int max(int, int);	//2个整形参数的函数原型
void main() {
	cout << max(55, max(25, 39)) << endl;
}
int max(int m1, int m2) {
	return m1 > m2 ? m1 : m2;
}