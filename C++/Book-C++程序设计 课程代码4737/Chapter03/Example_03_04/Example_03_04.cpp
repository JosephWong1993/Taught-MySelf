/* ʹ�á������βΡ���Ϊ�������������� */
#include<iostream>
#include<string>
using namespace std;
void swap(string&, string&);			//ʹ��string������ö�����Ϊ����
void main() {
	string str1("����"), str2("��ȥ");	//�������str1��str2
	swap(str1, str2);					//���ݶ�������֣�str1��str2
	cout << "���غ�str1 = " << str1 << " str2 = " << str2 << endl;
}
void swap(string& s1, string& s2) {		//string������ö���s1��s2��Ϊ��������
	string temp = s1; s1 = s2; s2 = temp;
	cout << "����Ϊ��str1 = " << s1 << " str2 = " << s2 << endl;
}