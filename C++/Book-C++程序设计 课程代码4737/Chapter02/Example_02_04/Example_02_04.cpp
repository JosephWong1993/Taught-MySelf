/* �������ʵ�� */
#include<iostream>
using namespace std;
class Point
{
private:
	double x, y;	//��Point�����ݳ�Ա
public:
	/// <summary>
	/// ��Point���޲������캯��
	/// </summary>
	Point() {}
	/// <summary>
	/// �������������Ĺ��캯��
	/// </summary>
	Point(double a, double b)
	{
		x = a; y = b;
	}
	/// <summary>
	/// ��Ա���������������������ݳ�Ա
	/// </summary>
	void Setxy(double a, double b)
	{
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
	Point a;				//������Point�Ķ���a
	Point b(18.5, 10.6);	//������Point�Ķ���b����ʼ��
	a.Setxy(10.6, 18.5);	//Ϊ����a�����ݳ�Ա��ֵ
	a.Display();			//��ʾ����a�����ݳ�Ա
	b.Display();			//��ʾ����b�����ݳ�Ա
}