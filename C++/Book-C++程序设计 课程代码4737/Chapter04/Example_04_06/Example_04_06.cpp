/* ��ʾnew������͹��캯���Ĺ�ϵ������ */
#include<iostream>
using namespace std;
class Point {
private:
	int x, y;
public:
	Point();
	Point(int, int);						//ʹ�ò����б�������2�������Ĺ��캯��
};
Point::Point() :x(0), y(0) {				//���岻�������Ĺ��캯��
	cout << "Initializing default" << endl;
}
Point::Point(int a, int b) : x(a), y(b) {	//��������������Ĺ��캯��
	cout << "Initializing " << a << "," << b << endl;
}
void main() {
	Point* ptr1 = new Point;
	Point* ptr2 = new Point(5, 7);
	delete ptr1;
	delete ptr2;
}