/* ʹ�ó�Ա������ʵ�� */
#include<iostream>;
using namespace std;

struct Point {
	/// <summary>
	/// ��Ա���������������������ݳ�Ա
	/// </summary>
	void Setxy(double a, double b) {
		x = a; y = b;
	}
	/// <summary>
	/// ��Ա��������ָ����ʽ������ݳ�Ա��ֵ
	/// </summary>
	void Display() {
		cout << x << "\t" << y << endl;
	}
	double x, y;			//���ݳ�Ա
};

void main() {
	Point a;				//�������a
	a.Setxy(10.6, 18.5);	//���ö���a�����ݳ�Ա
	a.Display();			//��ʾ����a�����ݳ�Ա
	cout << a.x << "\t" << a.y << endl;
}