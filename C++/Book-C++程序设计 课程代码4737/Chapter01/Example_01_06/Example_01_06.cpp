/* ��ʾ�����������򡢸��ơ����������Ȳ��������ӡ� */
#include<iostream>
#include<algorithm>	//ͷ�ļ�
using namespace std;
void main() {
	double a[] = { 1.1,4.4,3.3,2.2 }, b[4];
	copy(a, a + 4, ostream_iterator<double>(cout, " "));			//�����������a���Կո����
	cout << endl;
	reverse_copy(a, a + 4, ostream_iterator<double>(cout, " "));	//�����������a���Կո����
	cout << endl;
	copy(a, a + 4, b);
	copy(b, b + 4, ostream_iterator<double>(cout, " "));
	cout << endl;
	sort(a, a + 4);													//������a������������
	copy(a, a + 4, ostream_iterator<double>(cout, " "));			//�������a
	cout << endl;
	reverse_copy(a, a + 4, b);										//��a�����ݰ������Ƹ�����b
	copy(b, b + 4, ostream_iterator<double>(cout, " "));			//�������b
	cout << endl;
}