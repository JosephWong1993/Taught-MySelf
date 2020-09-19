/* 演示new运算符和构造函数的关系的例子 */
#include<iostream>
using namespace std;
class Point {
private:
	int x, y;
public:
	Point();
	Point(int, int);						//使用参数列表声明带2个参数的构造函数
};
Point::Point() :x(0), y(0) {				//定义不带参数的构造函数
	cout << "Initializing default" << endl;
}
Point::Point(int a, int b) : x(a), y(b) {	//定义带两个参数的构造函数
	cout << "Initializing " << a << "," << b << endl;
}
void main() {
	Point* ptr1 = new Point;
	Point* ptr2 = new Point(5, 7);
	delete ptr1;
	delete ptr2;
}