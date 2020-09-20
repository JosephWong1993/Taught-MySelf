#include<iostream>
using namespace std;
class Test {
	static int x;						//静态数据成员
	int n;
public:
	Test() {}
	Test(int a, int b) {
		x = a;
		n = b;
	}
	static int func() {					//静态成员函数
		return x;
	}
	static void sfunc(Test& r, int a) {	//静态成员函数
		r.n = a;
	}
	int Getn() {						//非静态成员函数
		return n;
	}
};
int Test::x = 25;				//初始化静态类型数据
void main() {
	cout << Test::func();		//x在产生对象之前即存在，输出25
	Test b, c;
	b.sfunc(b, 58);				//设置b对象的数据成员n
	cout << " " << b.Getn();
	cout << " " << b.func();	//x属于所有对象，输出25
	cout << " " << c.func();	//x属于所有对象，输出25
	Test a(24, 26);				//将类的x值改为24
	cout << " " << a.func() << " " << b.func() << " " << c.func() << endl;
}