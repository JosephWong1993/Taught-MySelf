#include<iostream>
using namespace std;
class number {
	int num;
public:
	number(int i) {
		num = i;
	}
	friend int operator++(number&);			//前缀: ++n
	friend int operator++(number&, int);	//后缀: n++
	void print() {
		cout << "num = " << num << endl;
	}
};
int operator++(number& a) {
	a.num++;
	return a.num;
}
int operator++(number& a, int) {			//不用给出int类型的形参名
	int i = a.num++;
	return i;
}
void main() {
	number n(10);
	int i = ++n;					//i = 11;n = 11
	cout << "i = " << i << endl;	//输出 i = 11
	n.print();						//输出 n = 11
	i = n++;						//i = 11;n = 12
	cout << "i = " << i << endl;	//输出i = 11
	n.print();						//输出 n = 12
}