/* ���ݶ�Point��Ķ��壬��ʾʹ��Point��Ķ��� */
#include<iostream>
using namespace std;

/* �������Point�� */
class Point						//���� Point
{
private:						//����Ϊ˽�з���Ȩ��
	int x, y;					//˽�����ݳ�Ա
public:							//����Ϊ���з���Ȩ��
	void Setxy(int a, int b);	//�޷���ֵ�Ĺ��г�Ա����
	void Move(int a, int b);	//�޷���ֵ�Ĺ��г�Ա����
	void Display();				//�޷���ֵ�Ĺ��г�Ա����
	int Getx();					//����ֵΪint�Ĺ��г�Ա����
	int Gety();					//����ֵΪint�Ĺ��г�Ա����
};								//�������ԷֺŽ���
void Point::Setxy(int a, int b) {
	x = a, y = b;
}
void Point::Move(int a, int b) {
	x = x + a;
	y = y + b;
}
void Point::Display() {
	cout << x << "," << y << endl;
}
inline int Point::Getx() {
	return x;
}
int Point::Gety() {
	return y;
}

void print(Point a) {
	a.Display();				//��ʾ����a�����ݳ�Ա��ֵ
}
void main() {
	Point A, B;					//��������
	A.Setxy(25, 55);			//Ϊ����A����ֵ
	B = A;						//B�����ݳ�ԱȡA�����ݳ�Աֵ֮
	A.Display();				//��ʾA�����ݳ�Ա
	A.Move(-10, 20);			//�ƶ�A
	print(A);					//�ȼ���A.Display();
	print(B);					//�ȼ���B.Display();
	cout << A.Getx() << endl;	//ֻ��ʹ��A.Getx(),����ʹ��A.x
}