/* 编写一个程序，用于计算正方形、矩形、直角三角形和圆的总面积 */
class shape {					//抽象类
public:
	virtual double area() = 0;	//纯虚函数
};
class square :public shape {	//抽象类派生正方形类
protected:
	double H;
public:
	square(double i) {
		H = i;
	}
	double area() {
		return H * H;
	}
};
class circle :public square {	//正方形类派生圆类
public:
	circle(double r) :square(r) {

	}
	double area() {
		return H * H * 3.14159;
	}
};
class triangle :public square {	//正方形派生直角三角形类
protected:
	double W;
public:
	triangle(double h, double w) :square(h) {
		W = w;
	}
	double area() {
		return H * W * 0.5;
	}
};
class rectangle :public triangle {	//直角三角形类派生矩形类
public:
	rectangle(double h, double w) :triangle(h, w) {}
	double area() {
		return H * W;
	}
};
double total(shape* s[], int n) {	//计算总面积函数
	double sum = 0.0;
	for (int i = 0; i < n; i++) {
		sum += s[i]->area();
	}
	return sum;
}
#include<iostream>
using namespace std;
void main() {
	shape* s[5];
	s[0] = new square(4);
	s[1] = new triangle(3, 6);
	s[2] = new rectangle(3, 6);
	s[3] = new square(6);
	s[4] = new circle(10);
	for (int i = 0; i < 5; i++)
	{
		cout << "s[" << i << "]" << s[i]->area() << endl;
	}
	double sum = total(s, 5);
	cout << "The total area is:" << sum << endl;
}