/* ��ʾ���ù��캯������ֵ���캯���������������ۺ����� */
#include<iostream>
using namespace std;
class Point {
private:
	int X, Y;
public:
	Point(int a = 0, int b = 0) {	//���캯��
		X = a;
		Y = b;
		cout << "Initializing" << endl;
	}
	Point(const Point& p);			//���ƹ��캯��
	int GetX() {
		return X;
	}
	int GetY() {
		return Y;
	}
	void Show() {
		cout << "X = " << X << ",Y = " << Y << endl;
	}
	~Point() {
		cout << "delete..." << X << "," << Y << endl;
	}
};
Point::Point(const Point& p) {		//���帴�ƹ��캯��
	X = p.X;
	Y = p.Y;
	cout << "Copy Initializing " << endl;
}
void display(Point p) {				//Point��Ķ�����Ϊ�������β�
	p.Show();
}
void disp(Point& p) {				//point������������Ϊ�������β�
	p.Show();
}
Point fun() {						//�����ķ���ֵΪPoint��Ķ���
	Point A(101, 202);
	return A;
}
void main() {
	Point A(42, 35);				//����A
	//��һ�ε��ø��ƹ��캯��
	Point B(A);						//��1����A��ʼ��B
	Point C(58, 94);				//����C
	cout << "called display(B)" << endl;
	//��2�ε��ø��ƹ��캯��
	display(B);						//����B��Ϊdisplay��ʵ��
	cout << "Next..." << endl;
	cout << "called disp(B)" << endl;
	disp(B);
	cout << "call C=fun()" << endl;
	//��3�ε��ø��ƹ��캯��
	C = fun();						//��3��fun�ķ���ֵ��������C
	cout << "called disp(C)" << endl;
	disp(C);
	cout << "out..." << endl;
}