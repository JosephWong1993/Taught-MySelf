/* 演示全局对象的例子 */
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

Point global(5, 7);

void main() {
	cout << "Entering main and exiting main" << endl;
}