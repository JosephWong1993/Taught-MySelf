/* ʹ������������ء�++������� */
#include<iostream>
using namespace std;
class number {
	int num;
public:
	number(int i) {
		num = i;
	}
	int operator++();		//ǰ׺:++n
	int operator++(int);	//��׺:n++
	void print() {
		cout << "num = " << num << endl;
	}
};
int number::operator++() {
	num++;
	return num;
}
int number::operator++(int) {	//���ø����β���
	int i = num;
	num++;
	return i;
}
void main() {
	number n(10);
	int i = ++n;					//i = 11;n = 11
	cout << "i = " << i << endl;	//��� i = 11
	n.print();						//��� n = 11
	i = n++;						//i = 11;n = 12
	cout << "i = " << i << endl;	//���i = 11
	n.print();						//��� n = 12
}