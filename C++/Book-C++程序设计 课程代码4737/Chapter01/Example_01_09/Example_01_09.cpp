/* ��ʾ���ַ�������в��������� */
#include<iostream>
#include<algorithm>
#include<functional>
using namespace std;
void main() {
	char a[] = "wearehere!", b[11];
	reverse(a, a + 10);									//����Ԫ������
	copy(a, a + 10, ostream_iterator<char>(cout));		//�����������������
	cout << endl;
	copy(a, a + 11, b);									//ԭ�����Ƶ�����b

	sort(a, a + 10);									//Ĭ����������
	cout << a << endl;									//���������
	cout << b << endl;									//�������b������
	reverse_copy(a, a + 10, b);							//�����Ƶ�����b
	cout << b << endl;									//�������������b������

	reverse(b + 2, b + 8);								//����b��������
	copy(b + 2, b + 8, ostream_iterator<char>(cout));	//�������b�����Ĳ�������
	cout << endl;

	sort(a, a + 10, greater<char>());					//��������
	cout << a << endl;									//�������������a
	cout << (*find(a, a + 10, 'e') == 'e') << " "
		<< (*find(a, a + 10, 'O') == 'O') << endl;
}