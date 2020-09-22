/* 访问具有二义性的例子 */
#include<iostream>
using namespace std;
class A {
public:
	void func() {
		cout << "a.func" << endl;
	}
};
class B {
public:
	void func() {
		cout << "b.func" << endl;
	}
	void gunc() {
		cout << "b.gunc" << endl;
	}
};
class C :public A, public B {
public:
	void gunc() {
		cout << "c.gunc" << endl;
	}
	//void hunc() {
	//	func();	//具有二义性
	//}
	void hun1() {
		A::func();	//使用基类A的func
	}
	void hun2() {
		B::func();	//使用基类B的func
	}
};
void main() {
	C obj;
	obj.A::func();	// => a.func();
	obj.B::func();	// => b.func();
	obj.B::gunc();	// => b.gunc();
	obj.C::gunc();	// => c.gunc();
	obj.gunc();		// => c.gunc();
	obj.hun1();		// => a.func();
	obj.hun2();		// => b.func();

	C c;
	C* c1 = new C;
	c.C::gunc();	//使用对象，输出c.gunc
	c1->C::gunc();	//使用指针，输出c.gunc
	c.B::func();	//使用对象，输出b.func
	c1->A::func();	//使用指针，输出a.func
}