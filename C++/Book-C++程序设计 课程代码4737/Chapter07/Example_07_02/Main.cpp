#include<iostream>
#include "Max4.cpp"
using namespace std;
void main() {
	Max4<char> C('W', 'w', 'a', 'A');								//�Ƚ��ַ�
	Max4<int> A(-25, -67, -66, -256);								//�Ƚ�����
	Max4<double>B(1.25, 4.3, -8.6, 3.5);							//�Ƚ�˫����ʵ��
	cout << C.Max() << " " << A.Max() << " " << B.Max() << endl;	// => w -25 4.3
}