/* ��One�Ķ���ͨ����Ԫ����������Two�Ķ����˽������ */
#include<iostream>
using namespace std;
class Two;	//��������Two�Ա���One����Two&
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
	void func(Two&);	//��������ĳ�Ա����������ΪTwo�������
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
	friend void One::func(Two&);	//������One�ĺ���Ϊ��Ԫ����
};
void One::func(Two& r) {	//������One�ĺ�����Ա
	r.y = x;				//�޸���Two�����ݳ�Ա
}
void main() {
	One Obj1(5);
	Two Obj2(8);
	cout << Obj1.Getx() << " " << Obj2.Gety() << endl;
	Obj1.func(Obj2);
	cout << Obj1.Getx() << " " << Obj2.Gety() << endl;
}