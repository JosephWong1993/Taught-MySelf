#pragma once
#include<iostream>
using namespace std;
class str
{
private:
	char* st;
public:
	str(char* s);				//ʹ���ַ�ָ��Ĺ��캯��
	str(str& s);				//ʹ�ö������õĹ��캯��
	str& operator= (str& a);	//����ʹ�ö������õĸ�ֵ�����
	str& operator=(char* s);	//����ʹ��ָ��ĸ�ֵ�����
	void print() {
		cout << st << endl;
	}
	~str() {
		delete st;
	}
};