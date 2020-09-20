/* ʹ��Point��Rectangle����ʾ��ֵ���ݹ�������� */
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
void main() {					//��ʾ���м̳еĸ�ֵ�����Թ���
	Point a(1, 2);				//�������a
	Rectangle b(3, 4, 5, 6);	//���������b
	a.Show();
	b.Show();
	Point& ra = b;				//����������ʼ�����������
	ra.Show();					//ʵ�ʵ��õ��ǻ����Show����
	Point* p = &b;				//���������ĵ�ַ����ָ������ָ��
	p->Show();					//ʵ�ʵ��õ��ǻ����Show����
	Rectangle* pb = &b;			//������ָ��pb
	pb->Show();					//�����������Show����
	a = b;						//��������������ֵ���»�����������ֵ
	a.Show();
}