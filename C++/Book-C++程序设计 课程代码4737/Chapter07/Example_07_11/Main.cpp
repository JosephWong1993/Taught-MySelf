/* ��ʾʹ�÷���ָ����в����ɾ��ʵ�� */
#include<iostream>
#include<vector>
#include<algorithm>
using namespace std;
void main() {
	char st[11] = "abcdefghij";
	vector<char> a(st, st + 10);									//�����Ʊ�ʶλ��\0��
	vector<char>::iterator p;										//���巺��ָ��p
	p = a.begin();													//pָ���1��Ԫ�صĵ�ַ
	a.insert(p + 3, 'X');											//a[3]='X'
	copy(a.begin(), a.end(), ostream_iterator<char>(cout, " "));	//������� a ������
	cout << endl;
	p = a.begin();													//p������λֵ
	a.insert(p, 3, 'A');											//��a[0]ǰ����3��A
	copy(a.begin(), a.end(), ostream_iterator<char>(cout, " "));	//������� A A A �������
	cout << endl;
	p = a.begin();
	a.erase(p + 8);													//ɾ��a[8]������9��Ԫ��e
	copy(a.begin(), a.end(), ostream_iterator<char>(cout, " "));	//���ɾ��e֮�������
	cout << endl;
}