/* ��ƹ��캯����Ĭ�ϲ��� */
#include<iostream>
using namespace std;
class Point {
private:
	int x, y;
public:
	Point(int = 0, int = 0);				//��������������ΪĬ�ϲ���
};
Point::Point(int a, int b) :x(a), y(b) {	//���幹�캯��
	cout << "Initializing " << a << "," << b << endl;
}
void main() {
	Point A;								//���캯����������A
	Point B(15, 25);						//���캯����������B
	Point C[2];								//���캯��������������C
}