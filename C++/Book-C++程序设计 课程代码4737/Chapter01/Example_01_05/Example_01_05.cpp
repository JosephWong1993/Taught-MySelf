//����������������
#include<iostream>
using namespace std;
typedef double array_[10];
void main() {
	array_ a = { 12,34,56,78,90,98,76,85,64,43 };
	array_& b = a;
	a[2] = 100;						//��������
	for (int i = 0; i < 10; i++)	//���� b ������ a ͬ���仯
		cout << b[i] << " ";
}