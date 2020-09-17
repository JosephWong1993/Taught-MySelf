/* 函数重载产生多态性的例子 */
#include<iostream>
using namespace std;
double max(double, double);	//2个实型参数的函数原型
int max(int, int);			//2个整形参数的函数原型
char max(char, char);		//2个字符型参数的函数原型
int max(int, int, int);		//3个整形参数的函数原型
void main() {
	cout << max(2.5, 17.54) << " " << max(56, 8) << " " << max('w', 'p') << endl;
	cout << "max(5,9,4) = " << max(5, 9, 4) << " max(5,4,9) = " << max(5, 4, 9) << endl;
}
double max(double m1, double m2) {
	return(m1 > m2) ? m1 : m2;
}
int max(int m1, int m2) {
	return(m1 > m2) ? m1 : m2;
}
char max(char m1, char m2) {
	return (m1 > m2) ? m1 : m2;
}
int max(int m1, int m2, int m3) {
	int t = max(m1, m2);
	return max(t, m3);
}