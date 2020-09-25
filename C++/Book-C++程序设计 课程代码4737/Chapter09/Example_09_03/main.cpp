/* 使用类运算符重载“++”运算符 */
#include<iostream>
using namespace std;
class number {
	int num;
public:
	number(int i) {
		num = i;
	}
	int operator++();		//前缀:++n
	int operator++(int);	//后缀:n++
	void print() {
		cout << "num = " << num << endl;
	}
};
int number::operator++() {
	num++;
	return num;
}
int number::operator++(int) {	//不用给出形参名
	int i = num;
	num++;
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