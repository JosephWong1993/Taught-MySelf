/* ���ؼ̳�ʹ���麯�� */
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
		cout << "Call B" << endl;	//����ʹ��virtual����
	}
};
class C :public A, public B {
public:
	void f() {						//����ʡ�Թؼ���virtual
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
	pa->f();	//��� Call C
	pb->f();	//��� Call C
	pc->f();	//��� Call C
}