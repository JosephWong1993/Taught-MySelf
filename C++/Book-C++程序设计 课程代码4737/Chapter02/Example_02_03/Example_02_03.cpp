/* ʹ�ù��캯����ʼ�������ʵ�� */
#include<iostream>
using namespace std;
struct Point
{
private:
	double x, y;	//���ݳ�Ա
public:
	/// <summary>
	/// �޲������캯��
	/// </summary>
	Point() {}
	/// <summary>
	/// �������������Ĺ��캯��
	/// </summary>
	Point(double a, double b) {
		x = a; y = b;
	}
	/// <summary>
	/// ��Ա���������������������ݳ�Ա
	/// </summary>
	void Setxy(double a, double b) {
		x = a; y = b;
	}
	/// <summary>
	/// ��Ա��������ָ����ʽ������ݳ�Ա��ֵ
	/// </summary>
	void Display()
	{
		cout << x << "\t" << y << endl;
	}
};

void main() {
	Point a;				//�������a
	Point b(18.5, 10.6);	//�������b����ֵ
	a.Setxy(10.6, 18.5);	//���ñ���a�����ݳ�Ա
	a.Display();			//��ʾ����a�����ݳ�Ա
	b.Display();			//��ʾ����b�����ݳ�Ա
}