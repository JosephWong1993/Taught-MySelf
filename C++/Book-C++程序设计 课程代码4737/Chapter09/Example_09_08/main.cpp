/* ʹ�ó�Ա�������ñ�־λ������ */
#include<iostream>
using namespace std;
const double PI = 3.141592;
void main() {
	int a = 15;
	cout.setf(ios_base::showpoint);	//��ʾʹ��setf��unsetf
	cout << 123.0 << " ";
	cout.unsetf(ios_base::showpoint);
	cout << 123.0 << endl;
	cout.setf(ios_base::showbase);
	cout.setf(ios_base::hex, ios_base::basefield);
	cout << a << " " << uppercase << hex << a << " " << nouppercase	//�Ƚ����ַ���
		<< hex << a << " " << noshowbase << a << dec << " " << a << endl;
	float c = 23.56F, d = -101.22F;
	cout.width(20);
	cout.setf(ios_base::scientific | ios_base::right | ios_base::showpos, ios::floatfield);
	cout << c << "\t" << d << "\t";
	cout.setf(ios_base::fixed | ios_base::showpos, ios_base::floatfield);
	cout << c << "\t" << d << endl;
	cout << cout.flags() << " " << 123.0 << " ";	//��ʾ���flags
	cout.flags(513);								//��ʾ����flags
	cout << 123.0 << endl;
	cout.setf(ios_base::scientific);				//��ʾʡ�Է�ʽ
	cout << 123.0 << endl;
	cout.width(8);									//��������ַ�����(n-1)
	cout << cout.fill('*') << 123 << endl;			//��ʾ���
}