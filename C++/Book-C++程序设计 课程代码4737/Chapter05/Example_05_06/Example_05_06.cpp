/* ��One�Ķ������ͨ������һ����Ա����������Two�Ķ����˽������ */
#include<iostream>
using namespace std;
class Two {
	int y;
public:
	friend class One;	//����OneΪTwo����Ԫ
};
class One {				//��One�ĳ�Ա����������Two����Ԫ
	int x;
public:
	One(int a, Two& r, int b) {
		x = a;
		r.y = b;		//ʹ�ù��캯��Ϊ��Two�Ķ���ֵ
	}
	void Display(Two&);	//��Ա�������Է�����Two�ĳ�Ա
};
void One::Display(Two& r) {				//����One�ĳ�Ա����Display
	cout << x << " " << r.y << endl;	//ʹ���Լ��ļ���Ԫ������˽������
}
void main() {
	Two Obj2;
	One Obj1(23, Obj2, 55);
	Obj1.Display(Obj2);	// => 23 55
}