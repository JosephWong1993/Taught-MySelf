/* 使用Point和Rectangle类演示赋值兼容规则的例子 */
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
void main() {					//演示公有继承的赋值兼容性规则
	Point a(1, 2);				//基类对象a
	Rectangle b(3, 4, 5, 6);	//派生类对象b
	a.Show();
	b.Show();
	Point& ra = b;				//派生类对象初始化基类的引用
	ra.Show();					//实际调用的是基类的Show函数
	Point* p = &b;				//派生类对象的地址赋给指向基类的指针
	p->Show();					//实际调用的是基类的Show函数
	Rectangle* pb = &b;			//派生类指针pb
	pb->Show();					//调用派生类的Show函数
	a = b;						//派生类对象的属性值更新基类对象的属性值
	a.Show();
}