//��ʾ���õ�����
#include <iostream>
using namespace std;
void main() {
	int x = 56;	//���岢��ʼ�� x
	int& a = x;	//���� a �� x �����ã�a �� x �ĵ�ַ��ͬ
	int& r = a;	//���� r �� a �����ã�r �� a �ĵ�ַ��ͬ������ x �ĵ�ַҲ��ͬ
	cout << "x = " << x << ",&x = " << &x << ",a = " << a << ",&a = " << &a
		<< ",r = " << r << ",&r = " << &r << endl;
	r = 25;		//�ı� r���� a �� x ��ͬ���仯
	cout << "x = " << x << ",&x = " << &x << ",a = " << a << ",&a = " << &a
		<< ",r = " << r << ",&r = " << &r << endl;
}