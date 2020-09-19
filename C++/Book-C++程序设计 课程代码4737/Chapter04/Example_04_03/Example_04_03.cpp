/* 演示使用内联函数定义Point类及使用Point类指针和引用的完整例子 */
#include<iostream>				//包含头文件
using namespace std;			//声明命名空间
class Point {					//使用内联函数定义类Point
private:						//声明为私有访问权限
	int x, y;					//私有数据成员
public:							//声明为公有访问权限
	void Setxy(int a, int b) {	//无返回值的内联公有成员函数
		x = a;
		y = b;
	}
	void Move(int a, int b) {	//无返回值的内联公有成员函数
		x = x + a;
		y = y + b;
	}
	void Display() {			//无返回值的内联公有成员函数
		cout << x << "," << y << endl;
	}
	int Getx() {				//返回值为int的内联公有成员函数
		return x;
	}
	int Gety() {				//返回值为int的内联公有成员函数
		return y;
	}
};								//类定义以分号结束

void print(Point* a) {			//类指针作为print函数的参数定义重载函数
	a->Display();
}
void print(Point& a) {			//类引用作为print函数的参数定义重载函数
	a.Display();
}
void main() {					//主函数
	Point A, B, * p;			//声明对象和指针
	Point& RA = A;				//声明对象RA引用对象A
	A.Setxy(25, 55);			//使用成员函数为对象A赋值
	B = A;						//使用赋值运算符为对象B赋值
	p = &B;						//类Point的指针指向对象B
	p->Setxy(112, 115);			//使用指针调用函数Setxy重新设置B的值
	print(p);					//传递指针显示对象B的属性
	p->Display();				//再次显示对象B的属性
	RA.Move(-80, 23);			//引用对象RA调用Move函数
	print(A);					//验证RA和A同步变化
	print(&A);					//直接传递A的地址作为指针参数
}