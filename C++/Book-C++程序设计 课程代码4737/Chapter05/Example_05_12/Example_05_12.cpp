/* ʹ��ָ�����Ա������ָ�� */
#include<iostream>
using namespace std;
class A {
private:
	int val;
public:
	A(int i) {
		val = i;
	}
	int value(int a) {
		return val + a;
	}
};
void main() {
	int(A:: * pfun)(int);				//����ָ����A�ĳ�Ա������ָ��
	pfun = &A::value;					//ָ��ָ������Ա����value
	A obj(10);							//��������obj
	cout << (obj.*pfun)(15) << endl;	//����ʹ����ĺ���ָ�룬���25
	A* pc = &obj;						//����A��ָ��pc
	cout << (pc->*pfun)(15) << endl;	//����ָ��ʹ����ĺ���ָ�룬���25
}