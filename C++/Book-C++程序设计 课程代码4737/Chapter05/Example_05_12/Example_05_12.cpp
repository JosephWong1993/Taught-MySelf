/* 使用指向类成员函数的指针 */
#include<iostream>
using namespace std;
class A {
private:
	int val;
public:
	A(int i) {
		val = i;
	}
	int value(int a) {
		return val + a;
	}
};
void main() {
	int(A:: * pfun)(int);				//声明指向类A的成员函数的指针
	pfun = &A::value;					//指针指向具体成员函数value
	A obj(10);							//创建对象obj
	cout << (obj.*pfun)(15) << endl;	//对象使用类的函数指针，输出25
	A* pc = &obj;						//对象A的指针pc
	cout << (pc->*pfun)(15) << endl;	//对象指针使用类的函数指针，输出25
}