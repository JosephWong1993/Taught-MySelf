/* ʹ��Ĭ����������ʵ�ֵ�һ�̳� */
#include<iostream>
using namespace std;
class Point {
private:
	int x, y;
public:
	Point(int a, int b) {
		x = a;
		y = b;
		cout << "Point..." << endl;
	}
	void Showxy() {
		cout << "x = " << x << ",y = " << y << endl;
	}
	~Point() {
		cout << "Delete Point" << endl;
	}
};
class Rectangle :public Point {
private:
	int H, W;
public:
	Rectangle(int a, int b, int h, int w) :Point(a, b) {	//���캯����ʼ���б�
		H = h;
		W = w;
		cout << "Rectangle..." << endl;
	};
	void Show() {
		cout << "H = " << H << ",W = " << W << endl;
	}
	~Rectangle() {
		cout << "Delete Rectangle" << endl;
	}
};
void main() {
	Rectangle r1(3, 4, 5, 6);
	r1.Showxy();	//�����������û���ĳ�Ա����
	r1.Show();		//������������������ĳ�Ա����
}