/* ��������ֵ��Ϊ�����Ĳ��� */
#include<iostream>
using namespace std;
int max(int, int);	//2�����β����ĺ���ԭ��
void main() {
	cout << max(55, max(25, 39)) << endl;
}
int max(int m1, int m2) {
	return m1 > m2 ? m1 : m2;
}