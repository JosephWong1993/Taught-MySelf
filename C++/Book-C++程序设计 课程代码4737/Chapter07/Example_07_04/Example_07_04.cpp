/* ���һ����ģ����Point�࣬Ȼ�����һ���̳�Point�����ģ��Line */
#include<iostream>
using namespace std;
class Point {							//��ģ����Point
	int x, y;
public:
	Point(int a, int b) {
		x = a;
		y = b;
	}
	void display() {
		cout << x << "," << y << endl;
	}
};
template<typename T>					//��ģ��
class Line :public Point {
	T x2, y2;
public:
	Line(int a, int b, T c, T d) :Point(a, b) {
		x2 = c;
		y2 = d;
	}
	void display() {
		Point::display();
		cout << x2 << "," << y2 << endl;
	}
};
void main() {
	Point a(3, 8);						//����a����������
	a.display();
	Line<int> ab(4, 5, 6, 7);			//�߶�ab�����������������
	ab.display();
	Line<double> ad(4, 5, 6.5, 7.8);	//�߶�ad��һ����������������һ����ʵ��
	ad.display();
}