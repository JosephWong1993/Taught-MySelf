/* ��ʾ����ָ���copy�������������� */
#include<iostream>
#include<algorithm>
#include<vector>
using namespace std;
void main() {
	double a[] = { 1.1,4.4,3.3,2.2 };
	vector<double> va(a, a + 4), vb(4);									//���岢��ʼ������va
	typedef vector<double>::iterator iterator;							//�Զ���һ��������ָ���ʶ��iterator
	iterator first = va.begin();										//����������ָ��first��ָ��va����Ԫ��
	for (first; first < va.end(); first++)								//ѭ���������va
	{
		cout << *first << " ";
	}
	for (--first; first > va.begin(); first--) {						//ѭ���������va
		cout << *first << " ";
	}
	copy(va.begin(), va.end(), ostream_iterator<double>(cout, " "));	//�����������va
	cout << endl;
	typedef vector<double>::reverse_iterator reverse_iterator;			//�Զ���һ��������ָ���ʶ��
	reverse_iterator last = va.rbegin();								//����������ָ��last��ָ��va��βԪ��
	for (last; last < va.rend(); last++) {								//ʹ������ָ��ѭ����β�������va
		cout << *last << " ";
	}
	for (--last; last > va.rbegin(); last--) {							//ʹ������ָ��ѭ�����׵�λ���va
		cout << *last << " ";
	}
	copy(va.rbegin(), va.rend(), ostream_iterator<double>(cout, " "));	//�����β�������va
}