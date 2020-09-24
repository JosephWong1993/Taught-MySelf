/* 使用积累成员函数的指针产生多态性 */
#include<iostream>
using namespace std;
class base {
public:
	virtual void print() {	//虚函数
		cout << "In Base" << endl;
	}
};
class derived :public base {
public:
	void print() {			//虚函数
		cout << "In Derived" << endl;
	}
};
void display(base* pb, void (base::* pf)()) {
	(pb->*pf)();
}
void main() {
	derived d;
	base* pb = &d;
	void(base:: * pf)();	//声明指向类base的成员函数的指针
	pf = &base::print;		//指针指向具体成员函数print
	display(pb, pf);		//输出Derived
}