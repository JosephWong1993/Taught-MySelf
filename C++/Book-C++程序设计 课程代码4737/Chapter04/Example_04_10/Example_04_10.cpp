/* ����һ����4�������������ֵ����Max��������������֤���Ĺ��� */
#include<iostream>
using namespace std;

class Max {
private:
	int a, b, c, d;
	int Maxi(int, int);
public:
	void Set(int, int, int, int);
	int Maxi();
} A[3];
//���г�Ա������ʵ��
int Max::Maxi(int x, int y) {	//�������������ֵ
	return (x > y) ? x : y;
}
void Max::Set(int x1, int x2, int x3 = 0, int x4 = 0) {	//ʹ������Ĭ�ϲ���
	a = x1;
	b = x2;
	c = x3;
	d = x4;
}
int Max::Maxi() {
	int x = Maxi(a, b);
	int y = Maxi(c, d);
	return Maxi(x, y);
}

//������
void main() {
	A[0].Set(12, 45, 76, 89);	//Ϊ�������A[0]�ó�ֵ
	A[1].Set(12, 45, 76);		//Ϊ�������A[1]�ó�ֵ
	A[2].Set(12, 45);			//Ϊ�������A[2]�ó�ֵ
	for (int i = 0; i < 3; i++)	//���������ֵ���
	{
		cout << A[i].Maxi() << " ";
	}
}