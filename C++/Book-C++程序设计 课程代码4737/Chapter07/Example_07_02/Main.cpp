#include<iostream>
#include "Max4.cpp"
using namespace std;
void main() {
	Max4<char> C('W', 'w', 'a', 'A');								//比较字符
	Max4<int> A(-25, -67, -66, -256);								//比较整数
	Max4<double>B(1.25, 4.3, -8.6, 3.5);							//比较双精度实数
	cout << C.Max() << " " << A.Max() << " " << B.Max() << endl;	// => w -25 4.3
}