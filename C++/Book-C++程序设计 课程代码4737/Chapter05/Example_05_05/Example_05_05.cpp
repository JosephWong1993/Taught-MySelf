/* 类One的对象通过友元函数访问类Two的对象的私有数据 */
#include<iostream>
using namespace std;
class Two;	//先声明类Two以便类One引用Two&
class One {
private:
	int x;
public:
	One(int a) {
		x = a;
	}
	int Getx() {
		return x;
	}
	void func(Two&);	//声明本类的成员函数，参数为Two类的引用
};
class Two {
private:
	int y;
public:
	Two(int b) {
		y = b;
	}
	int Gety() {
		return y;
	}
	friend void One::func(Two&);	//声明类One的函数为友元函数
};
void One::func(Two& r) {	//定义类One的函数成员
	r.y = x;				//修改类Two的数据成员
}
void main() {
	One Obj1(5);
	Two Obj2(8);
	cout << Obj1.Getx() << " " << Obj2.Gety() << endl;
	Obj1.func(Obj2);
	cout << Obj1.Getx() << " " << Obj2.Gety() << endl;
}