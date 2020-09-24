/* 多重继承使用虚函数 */
#include<iostream>
using namespace std;
class A {
public:
	virtual void f() {
		cout << "Call A" << endl;
	}
};
class B {
public:
	virtual void f() {
		cout << "Call B" << endl;	//必须使用virtual声明
	}
};
class C :public A, public B {
public:
	void f() {						//可以省略关键字virtual
		cout << "Call C" << endl;
	}
};
void main() {
	A* pa;
	B* pb;
	C* pc, c;
	pa = &c;
	pb = &c;
	pc = &c;
	pa->f();	//输出 Call C
	pb->f();	//输出 Call C
	pc->f();	//输出 Call C
}