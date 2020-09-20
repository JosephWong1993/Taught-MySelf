/* 使用类对象数组和指针的例子 */
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
	Test one[2] = { 2,4 }, * p;
	Test two[2] = {
		Test(1,3.2),
		Test(5,9.5)
	};
	int i;
	for (i = 0; i < 2; i++)	//输出对象数组元素
	{
		cout << "one[" << i << "] = " << one[i].GetNum() << endl;
	}
	p = two;				//使用指针输出对象数组元素
	for (i = 0; i < 2; i++, p++) {
		cout << "two[" << i << "] = (" << p->GetNum() << ","
			<< p->GetF() << ")" << endl;
	}
}