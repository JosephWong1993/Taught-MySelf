/* �������õĺ��� */
#include<iostream>
using namespace std;
int a[] = { 2,4,6,8,10,12 };	//ȫ������
int& index(int i);				//�������õĺ���ԭ������
void main() {
	index(3) = 16;				//��a[3]�ĳ�16
	cout << index(3) << endl;	//���16
}
int& index(int i) {				//��������
	return a[i];				//����ָ���±��������������
}