#include "Sum.h"
#include<iostream>
using namespace std;
void main() {
	Sum<int, 4> num1(-23, 5, 8, -2);			//�������
	Sum<float, 4>f1(3.5f, -8.5f, 8.8f, 9.7f);	//��������ͣ�ʹ��f��ʽ˵��float����
	Sum<double, 4>d1(355.4, 253.8, 456.7, -67.8);
	Sum<char, 4>c1('W', -2, -1, -1);			//�ַ�������Ч��'W'-4�����Ϊ'S'
	cout << num1.S() << " ," << f1.S() << " ," << d1.S() << " , " << c1.S() << endl;
}