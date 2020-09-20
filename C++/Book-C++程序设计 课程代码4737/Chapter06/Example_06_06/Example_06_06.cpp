/* ���ʾ��ж����Ե����� */
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
	//	func();	//���ж�����
	//}
	void hun1() {
		A::func();	//ʹ�û���A��func
	}
	void hun2() {
		B::func();	//ʹ�û���B��func
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
	c.C::gunc();	//ʹ�ö������c.gunc
	c1->C::gunc();	//ʹ��ָ�룬���c.gunc
	c.B::func();	//ʹ�ö������b.func
	c1->A::func();	//ʹ��ָ�룬���a.func
}