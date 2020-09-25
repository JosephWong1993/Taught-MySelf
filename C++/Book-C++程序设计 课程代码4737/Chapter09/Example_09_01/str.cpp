#include "str.h"
#include<string>
using namespace std;
str::str(char* s) {
	st = new char[strlen(s) + 1];		//Ϊst�����ڴ�
	strcpy(st, s);						//���ַ���s���Ƶ��ڴ���st
}
str::str(str& a) {
	st = new char[strlen(a.st) + 1];	//Ϊst�����ڴ�
	strcpy(st, a.st);					//������a���ַ������Ƶ��ڴ���st
}
str& str::operator=(str& a) {
	if (this == &a)						//��ֹa=a�����ĸ�ֵ
		return *this;					//a=a,�˳�
	delete st;							//�����������ͷ��ڴ�ռ�
	st = new char[strlen(a.st) + 1];	//���������ڴ�
	strcpy(st, a.st);					//������a���ַ������Ƶ�������ڴ���
	return *this;						//����thisָ��ָ��Ķ���
}
str& str::operator=(char* s) {
	delete st;							//���ַ���ֱ�Ӹ�ֵ�����ͷ��ڴ�ռ�
	st = new char[strlen(s) + 1];		//���������ڴ�
	strcpy(st, s);						//���ַ���s���Ƶ��ڴ���st
	return *this;
}