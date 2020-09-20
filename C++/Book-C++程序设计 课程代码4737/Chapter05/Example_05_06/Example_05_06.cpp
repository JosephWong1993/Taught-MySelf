/* 类One的对象可以通过任意一个成员函数访问类Two的对象的私有数据 */
#include<iostream>
using namespace std;
class Two {
	int y;
public:
	friend class One;	//声明One为Two的友元
};
class One {				//类One的成员函数均是类Two的友元
	int x;
public:
	One(int a, Two& r, int b) {
		x = a;
		r.y = b;		//使用构造函数为类Two的对象赋值
	}
	void Display(Two&);	//成员函数可以访问类Two的成员
};
void One::Display(Two& r) {				//定义One的成员函数Display
	cout << x << " " << r.y << endl;	//使用自己的及友元类对象的私有数据
}
void main() {
	Two Obj2;
	One Obj1(23, Obj2, 55);
	Obj1.Display(Obj2);	// => 23 55
}