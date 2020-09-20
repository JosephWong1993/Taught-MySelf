/* 演示使用protected成员 */
#include<iostream>
using namespace std;
class Point {
protected:
	int x, y;	//声明保护数据成员
public:
	Point(int a, int b) {
		x = a;
		y = b;
	}
	void Show() {	//基类的Show()函数
		cout << "x = " << x << ",y = " << y << endl;
	}
};
class Rectangle :public Point {
private:
	int H, W;
public:
	Rectangle(int, int, int, int);	//构造函数原型
	void Show() {
		cout << "x = " << x << ",y = " << y << ",H = " << H << ",W = " << W << endl;
	}
};
Rectangle::Rectangle(int a, int b, int h, int w) :Point(a, b) {	//定义构造函数
	H = h;
	W = w;
};
void main() {
	Point a(3, 4);
	Rectangle r1(3, 4, 5, 6);
	a.Show();	//基类对象调用基类Show()函数
	r1.Show();	//派生类对象调用派生类Show()函数
}