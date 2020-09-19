/* 演示调用构造函数、赋值构造函数及析构函数的综合例子 */
#include<iostream>
using namespace std;
class Point {
private:
	int X, Y;
public:
	Point(int a = 0, int b = 0) {	//构造函数
		X = a;
		Y = b;
		cout << "Initializing" << endl;
	}
	Point(const Point& p);			//复制构造函数
	int GetX() {
		return X;
	}
	int GetY() {
		return Y;
	}
	void Show() {
		cout << "X = " << X << ",Y = " << Y << endl;
	}
	~Point() {
		cout << "delete..." << X << "," << Y << endl;
	}
};
Point::Point(const Point& p) {		//定义复制构造函数
	X = p.X;
	Y = p.Y;
	cout << "Copy Initializing " << endl;
}
void display(Point p) {				//Point类的对象作为函数的形参
	p.Show();
}
void disp(Point& p) {				//point类对象的引用作为函数的形参
	p.Show();
}
Point fun() {						//函数的返回值为Point类的对象
	Point A(101, 202);
	return A;
}
void main() {
	Point A(42, 35);				//对象A
	//第一次调用复制构造函数
	Point B(A);						//（1）用A初始化B
	Point C(58, 94);				//对象C
	cout << "called display(B)" << endl;
	//第2次调用复制构造函数
	display(B);						//对象B作为display的实参
	cout << "Next..." << endl;
	cout << "called disp(B)" << endl;
	disp(B);
	cout << "call C=fun()" << endl;
	//第3次调用复制构造函数
	C = fun();						//（3）fun的返回值赋给对象C
	cout << "called disp(C)" << endl;
	disp(C);
	cout << "out..." << endl;
}