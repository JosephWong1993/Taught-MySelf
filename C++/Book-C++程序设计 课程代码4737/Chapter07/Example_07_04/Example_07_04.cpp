/* 设计一个非模板类Point类，然后设计一个继承Point类的类模板Line */
#include<iostream>
using namespace std;
class Point {							//非模板类Point
	int x, y;
public:
	Point(int a, int b) {
		x = a;
		y = b;
	}
	void display() {
		cout << x << "," << y << endl;
	}
};
template<typename T>					//类模板
class Line :public Point {
	T x2, y2;
public:
	Line(int a, int b, T c, T d) :Point(a, b) {
		x2 = c;
		y2 = d;
	}
	void display() {
		Point::display();
		cout << x2 << "," << y2 << endl;
	}
};
void main() {
	Point a(3, 8);						//对象a是整数坐标
	a.display();
	Line<int> ab(4, 5, 6, 7);			//线段ab的两个坐标均是整数
	ab.display();
	Line<double> ad(4, 5, 6.5, 7.8);	//线段ad的一个坐标是整数，另一个是实数
	ad.display();
}