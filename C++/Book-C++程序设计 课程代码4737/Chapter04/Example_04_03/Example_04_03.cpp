/* ��ʾʹ��������������Point�༰ʹ��Point��ָ������õ��������� */
#include<iostream>				//����ͷ�ļ�
using namespace std;			//���������ռ�
class Point {					//ʹ����������������Point
private:						//����Ϊ˽�з���Ȩ��
	int x, y;					//˽�����ݳ�Ա
public:							//����Ϊ���з���Ȩ��
	void Setxy(int a, int b) {	//�޷���ֵ���������г�Ա����
		x = a;
		y = b;
	}
	void Move(int a, int b) {	//�޷���ֵ���������г�Ա����
		x = x + a;
		y = y + b;
	}
	void Display() {			//�޷���ֵ���������г�Ա����
		cout << x << "," << y << endl;
	}
	int Getx() {				//����ֵΪint���������г�Ա����
		return x;
	}
	int Gety() {				//����ֵΪint���������г�Ա����
		return y;
	}
};								//�ඨ���ԷֺŽ���

void print(Point* a) {			//��ָ����Ϊprint�����Ĳ����������غ���
	a->Display();
}
void print(Point& a) {			//��������Ϊprint�����Ĳ����������غ���
	a.Display();
}
void main() {					//������
	Point A, B, * p;			//���������ָ��
	Point& RA = A;				//��������RA���ö���A
	A.Setxy(25, 55);			//ʹ�ó�Ա����Ϊ����A��ֵ
	B = A;						//ʹ�ø�ֵ�����Ϊ����B��ֵ
	p = &B;						//��Point��ָ��ָ�����B
	p->Setxy(112, 115);			//ʹ��ָ����ú���Setxy��������B��ֵ
	print(p);					//����ָ����ʾ����B������
	p->Display();				//�ٴ���ʾ����B������
	RA.Move(-80, 23);			//���ö���RA����Move����
	print(A);					//��֤RA��Aͬ���仯
	print(&A);					//ֱ�Ӵ���A�ĵ�ַ��Ϊָ�����
}