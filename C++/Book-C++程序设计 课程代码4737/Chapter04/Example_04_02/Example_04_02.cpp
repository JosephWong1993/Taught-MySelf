/* 根据对Point类的定义，演示使用Point类的对象 */
#include<iostream>
using namespace std;

/* 描述点的Point类 */
class Point						//类名 Point
{
private:						//声明为私有访问权限
	int x, y;					//私有数据成员
public:							//声明为公有访问权限
	void Setxy(int a, int b);	//无返回值的公有成员函数
	void Move(int a, int b);	//无返回值的公有成员函数
	void Display();				//无返回值的公有成员函数
	int Getx();					//返回值为int的公有成员函数
	int Gety();					//返回值为int的公有成员函数
};								//类声明以分号结束
void Point::Setxy(int a, int b) {
	x = a, y = b;
}
void Point::Move(int a, int b) {
	x = x + a;
	y = y + b;
}
void Point::Display() {
	cout << x << "," << y << endl;
}
inline int Point::Getx() {
	return x;
}
int Point::Gety() {
	return y;
}

void print(Point a) {
	a.Display();				//显示对象a的数据成员的值
}
void main() {
	Point A, B;					//声明对象
	A.Setxy(25, 55);			//为对象A赋初值
	B = A;						//B的数据成员取A的数据成员之值
	A.Display();				//显示A的数据成员
	A.Move(-10, 20);			//移动A
	print(A);					//等价于A.Display();
	print(B);					//等价于B.Display();
	cout << A.Getx() << endl;	//只能使用A.Getx(),不能使用A.x
}