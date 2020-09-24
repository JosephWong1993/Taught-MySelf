/* ʹ�û��۳�Ա������ָ�������̬�� */
#include<iostream>
using namespace std;
class base {
public:
	virtual void print() {	//�麯��
		cout << "In Base" << endl;
	}
};
class derived :public base {
public:
	void print() {			//�麯��
		cout << "In Derived" << endl;
	}
};
void display(base* pb, void (base::* pf)()) {
	(pb->*pf)();
}
void main() {
	derived d;
	base* pb = &d;
	void(base:: * pf)();	//����ָ����base�ĳ�Ա������ָ��
	pf = &base::print;		//ָ��ָ������Ա����print
	display(pb, pf);		//���Derived
}