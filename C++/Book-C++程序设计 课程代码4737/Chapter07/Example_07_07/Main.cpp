/* ��ʾ����ʹ��ʵ�����͵����� */
#include<iostream>
#include<algorithm>
#include<functional>
#include<vector>
using namespace std;
void main() {
	double a[] = { 1.1,4.4,3.3,2.2 };
	vector<double> va(a, a + 4), vb(4);											//����ʵ������va
	copy(va.begin(), va.end(), ostream_iterator<double>(cout, " "));			//�������va
	cout << endl;
	reverse_copy(va.begin(), va.end(), ostream_iterator<double>(cout, " "));	//�������va
	cout << endl;
	reverse_copy(va.begin(), va.end(), vb.begin());								//va�����Ƹ�vb
	copy(vb.begin(), vb.end(), ostream_iterator<double>(cout, " "));			//�������vb
	cout << endl;
	sort(va.begin(), va.end());													//va��������
	sort(vb.begin(), vb.end(), greater<double>());								//vb��������
	copy(va.begin(), va.end(), ostream_iterator<double>(cout, " "));			//�������va
	cout << endl;
	copy(vb.begin(), vb.end(), ostream_iterator<double>(cout, " "));			//�������vb
	cout << endl;
	cout << *find(va.begin(), va.end(), 4.4);									//��va�в���4.4
}