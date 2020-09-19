/* 使用Point类演示建立和释放一个动态对象数组的例子 */
#include<iostream>
using namespace std;
class Point {
private:
	int x, y;
public:
	Point(int = 0, int = 0);				//声明两个参数均为默认参数
	~Point();								//声明析构函数
};
Point::Point(int a, int b) :x(a), y(b) {	//定义构造函数
	cout << "Initializing " << a << "," << b << endl;
}
Point::~Point() {							//定义析构函数
	cout << "Destructor is acvtive" << endl;
}
void main() {
	Point* ptr = new Point[2];
	delete[] ptr;
}