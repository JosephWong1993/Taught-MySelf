/* ��ʾʹ�ñ�־λ������ */
#include<iostream>
using namespace std;
const double PI = 3.141592;
void main() {
	int a = 15;
	bool it = 1, not_ = 0;
	cout << showpoint << 123.0 << " "	//���С��λ
		<< noshowpoint << 123.0 << " ";	//�����С��λ
	cout << showbase;					//��ʾ�������
	cout << a << " " << uppercase << hex << a << " " << nouppercase	//��ʾ��Сд
		<< hex << a << " " << noshowbase << a << dec << a << endl;
	cout << uppercase << scientific << PI << " " << nouppercase << PI << " " << fixed << PI << endl;
	cout << cout.precision() << " " << PI << " ";					//��ʾcout�ĳ�Ա����
	cout.precision(4);
	cout << cout.precision() << " " << PI << endl;
	cout.width(10);
	cout << showpos << right << a << " " << noshowpos << PI << " ";	//��ʾ��ֵ����
	cout << it << " " << not_ << " "								//��ʾbool
		<< boolalpha << it << " " << " " << not_ << " "
		<< noboolalpha << " " << it << " " << not_ << endl;
	cout.width(10);
	cout << left << PI << " " << 123 << " " << cout.width() << " ";
	cout << 123 << " " << cout.width() << endl;
}