/* ��ʾ˫����ʵ����� */
#include<iostream>
#include<vector>
using namespace std;
void main() {
	char st[11] = "abcdefghij";
	vector<char> a(st, st + 10);
	vector<char>::iterator p = a.begin();			//����������ָ�벢��ʼ��
	vector<char>::reverse_iterator ps;				//����������ָ��
	for (p = a.begin(); p != a.end(); ++p)			//�������
	{
		cout << *p << " ";							//���a b c d e f g h i j
	}
	cout << endl;
	for (p = a.end() - 1; p != a.begin(); --p) {	//ʹ���������������
		cout << *p << " ";							//���j i h g f e d c b
	}
	cout << endl;
	for (ps = a.rbegin(); ps != a.rend(); ++ps)		//ʹ��������ָ��������ʣ�����++����
	{
		cout << *ps << " ";							//��� j i g f e d c b a
	}
	cout << endl;
	for (--ps; ps != a.rbegin(); --ps)				//ʹ��������ָ��������ʣ�����--����
	{
		cout << *ps << " ";							//��� a b c d e f g h i
	}
}