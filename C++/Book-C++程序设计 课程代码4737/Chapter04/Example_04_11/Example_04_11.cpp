/* ʹ�ö����Ա������ */
#include<iostream>
using namespace std;
class Point {			//�������
	int x, y;
public:
	void Set(int a, int b) {
		x = a; y = b;
	}
	int Getx() {
		return x;
	}
	int Gety() {
		return y;
	}
};
class Rectangle {				//�ھ�������ʹ��Point��ĳ�Ա
	Point Loc;					//����һ��Point��Ķ�����Ϊ����
	int H, W;					//HΪ�ߣ�WΪ��
public:
	void Set(int x, int y, int h, int w);
	Point* GetLoc();			//��������Point��ָ��ĳ�Ա����
	int GetHeight() {
		return H;
	}
	int GetWidth() {
		return W;
	}
};
void Rectangle::Set(int x, int y, int h, int w) {
	Loc.Set(x, y);				//��ʼ�����궥��
	H = h, W = w;
}
Point* Rectangle::GetLoc() {	//��������Point*,��ΪRectangle�ĳ�Ա����
	return &Loc;				//���ض���Loc�ĵ�ַ
}
void main() {
	Rectangle rect;
	rect.Set(10, 2, 25, 20);
	cout << rect.GetHeight() << "," << rect.GetWidth() << ",";
	Point* p = rect.GetLoc();	//����Point���ָ�����p����ʼ��
	cout << p->Getx() << "," << p->Gety() << endl;
}