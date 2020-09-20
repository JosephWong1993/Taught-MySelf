#include<iostream>
using namespace std;

class Test {
	int num;
	double f1;
public:
	Test(int n) {			//一个参数的构造函数
		num = n;
	}
	Test(int n, double f) {	//两个参数的构造函数
		num = n; f1 = f;
	}
	int GetNum() {
		return num;
	}
	double GetF() {
		return f1;
	}
};

void main() {
	Test* one[2] = { new Test(2),new Test(4) };
	Test* two[2] = { new Test(1,3.2),new Test(5,9.5) };
	int i;
	for (i = 0; i < 2; i++)
	{
		cout << "one[" << i << "] = " << one[i]->GetNum() << endl;
	}
	for (i = 0; i < 2; i++) {
		cout << "two[" << i << "] = (" << two[i]->GetNum() << ","
			<< two[i]->GetF() << ")" << endl;
	}
}