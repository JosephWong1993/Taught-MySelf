#include<iostream>
using namespace std;
class number {
	int num;
public:
	number(int i) {
		num = i;
	}
	friend int operator++(number&);			//ǰ׺: ++n
	friend int operator++(number&, int);	//��׺: n++
	void print() {
		cout << "num = " << num << endl;
	}
};
int operator++(number& a) {
	a.num++;
	return a.num;
}
int operator++(number& a, int) {			//���ø���int���͵��β���
	int i = a.num++;
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