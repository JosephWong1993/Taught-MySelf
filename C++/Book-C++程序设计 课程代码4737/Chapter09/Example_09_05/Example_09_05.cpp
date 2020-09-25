/* 使用对象作为友元函数参数来定义运算符“+”的例子 */
#include<iostream>
using namespace std;
class complex_ {
private:
	double real, imag;
public:
	complex_(double r = 0, double i = 0) {
		real = r;
		imag = i;
	}
	friend complex_ operator+(complex_, complex_);
	void show() {
		cout << real << " + " << imag << "i";
	}
};
complex_ operator+(complex_ a, complex_ b)
{
	double r = a.real + b.real;
	double i = a.imag + b.imag;
	return complex_(r, i);
}
void main() {
	complex_ x(5, 3), y;
	y = x + 7;	//12+3i
	y = 7 + y;	//19+3i
	y.show();	//输出 19+3i
}