#pragma once
#include<iostream>
using namespace std;
class str
{
private:
	char* st;
public:
	str(char* s);				//使用字符指针的构造函数
	str(str& s);				//使用对象引用的构造函数
	str& operator= (str& a);	//重载使用对象引用的赋值运算符
	str& operator=(char* s);	//重载使用指针的赋值运算符
	void print() {
		cout << st << endl;
	}
	~str() {
		delete st;
	}
};