/* ��ʾʹ��protected��Ա */
#include<iostream>
using namespace std;
class Point {
protected:
	int x, y;	//�����������ݳ�Ա
public:
	Point(int a, int b) {
		x = a;
		y = b;
	}
	void Show() {	//�����Show()����
		cout << "x = " << x << ",y = " << y << endl;
	}
};
class Rectangle :public Point {
private:
	int H, W;
public:
	Rectangle(int, int, int, int);	//���캯��ԭ��
	void Show() {
		cout << "x = " << x << ",y = " << y << ",H = " << H << ",W = " << W << endl;
	}
};
Rectangle::Rectangle(int a, int b, int h, int w) :Point(a, b) {	//���幹�캯��
	H = h;
	W = w;
};
void main() {
	Point a(3, 4);
	Rectangle r1(3, 4, 5, 6);
	a.Show();	//���������û���Show()����
	r1.Show();	//������������������Show()����
}