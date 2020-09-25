#include "str.h"
#include<string>
using namespace std;
str::str(char* s) {
	st = new char[strlen(s) + 1];		//为st申请内存
	strcpy(st, s);						//将字符串s复制到内存区st
}
str::str(str& a) {
	st = new char[strlen(a.st) + 1];	//为st申请内存
	strcpy(st, a.st);					//将对象a的字符串复制到内存区st
}
str& str::operator=(str& a) {
	if (this == &a)						//防止a=a这样的赋值
		return *this;					//a=a,退出
	delete st;							//不是自身，先释放内存空间
	st = new char[strlen(a.st) + 1];	//重新申请内存
	strcpy(st, a.st);					//将对象a的字符串复制到申请的内存区
	return *this;						//返回this指针指向的对象
}
str& str::operator=(char* s) {
	delete st;							//是字符串直接赋值，先释放内存空间
	st = new char[strlen(s) + 1];		//重新申请内存
	strcpy(st, s);						//将字符串s复制到内存区st
	return *this;
}