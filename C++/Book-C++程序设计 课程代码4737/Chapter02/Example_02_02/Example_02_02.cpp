/* ʹ�ṹ���з�װ�Ե�ʵ�� */
#include<iostream>
using namespace std;
struct Point
{
private:
	double x, y;	//���ݳ�Ա
public:
	/// <summary>
	/// ��Ա���������������������ݳ�Ա
	/// </summary>
	void Setxy(double a, double b)
	{
		x = a;
		y = b;
	}

	void Display()
	{
		cout << x << "\t" << y << endl;
	}
};

void main() {
	Point a;				//�������a
	a.Setxy(10.6, 18.5);	//���ö���a�����ݳ�Ա
	a.Display();			//��ʾ����a�����ݳ�Ա
	//cout << a.x << "\t" << a.y << endl;
}