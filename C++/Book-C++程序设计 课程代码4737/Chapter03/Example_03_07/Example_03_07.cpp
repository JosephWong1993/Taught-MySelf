/* ������ı���Ϊ�������ݵ��ַ������ݵ�ʵ�� */
#include<iostream>
#include<string>
using namespace std;
void change(const string&);
void main() {
	string str("Can you change it?");
	change(str);
	cout << str << endl;
}
void change(const string& s) {
	string s2 = s + " No!";
	cout << s2 << endl;
}