/* ��ʾʹ�ø�����ͽṹ��Ϊ��������Ԫ�ص����� */
#include<iostream>
#include<complex>
#include<vector>
using namespace std;
struct st {
	int a, b;
} a[]{ {2,5},{4,8} };
void main() {
	complex<float> num[] = { complex<float>(2,3),complex<float>(3.5,4.5) };
	vector<complex<float>*> vnum(2);	//�������ָ����Ϊ��������������
	vnum[0] = &num[0];
	vnum[1] = &num[1];
	int i;
	for (i = 0; i < 2; i++)
	{
		cout << "real is " << vnum[i]->real() << ", image is " << vnum[i]->imag() << endl;
	}
	vector<st*> cp(2);					//�ṹָ����Ϊ��������������
	cp[0] = &a[0];
	cp[1] = &a[1];
	for (i = 0; i < 2; i++)
	{
		cout << "a = " << cp[i]->a << ", b = " << cp[i]->b << endl;
	}
}