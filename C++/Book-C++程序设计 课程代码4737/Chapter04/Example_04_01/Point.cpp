#include<iostream>;
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