/* ʹ����Ԫ�������������������� */
#include<iostream>
#include<cmath>	//Ҳ����ʹ��ͷ�ļ�<math.h>
using namespace std;
class Point {
private:
	double X, Y;
public:
	Point(double xi, double yi) {
		X = xi;
		Y = yi;
	}
	double GetX() {
		return X;
	}
	double GetY() {
		return Y;
	}
	friend double distances(Point&, Point&);	//������Ԫ����
};
double distances(Point& a, Point& b) {	//����ͨ����һ��������Ԫ����
	double dx = a.X - b.X;				//���Է��ʶ���a�ĳ�Ա
	double dy = a.Y - b.Y;				//���Է��ʶ���b�ĳ�Ա
	return sqrt(dx * dx + dy * dy);
}
void main() {
	Point p1(3.5, 5.5), p2(4.5, 6.5);
	cout << "The distance is " << distances(p1, p2) << endl;
}