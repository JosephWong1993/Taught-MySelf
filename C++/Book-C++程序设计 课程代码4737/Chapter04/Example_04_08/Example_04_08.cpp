/* ʹ��Point����ʾ�������ͷ�һ����̬������������� */
#include<iostream>
using namespace std;
class Point {
private:
	int x, y;
public:
	Point(int = 0, int = 0);				//��������������ΪĬ�ϲ���
	~Point();								//������������
};
Point::Point(int a, int b) :x(a), y(b) {	//���幹�캯��
	cout << "Initializing " << a << "," << b << endl;
}
Point::~Point() {							//������������
	cout << "Destructor is acvtive" << endl;
}
void main() {
	Point* ptr = new Point[2];
	delete[] ptr;
}