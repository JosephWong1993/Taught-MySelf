/* ��ʾ��������������Ϣ������ʵ�� */
#include<iostream>
#include<algorithm>
#include<functional>
#include<vector>
using namespace std;
void main() {
	vector<char> a(10), b(10);														//��������a,Ԫ�����ݾ�Ϊ0
	cout << a.empty() << "," << sizeof(a) << ",";									//���ݲ���ʱ���0,sizeof(a)Ϊ16
	char j;
	for (char i = 'a', j = 0; j < 10; j++)											//�ı�����Ϊ��abcdefghij
	{
		a[j] = i + j;
	}
	cout << a.max_size() << "," << a.capacity() << "," << a.size() << endl;			//�Ƚ�����������С
	for (j = 0; j < 10; j++)														//�����������
	{
		cout << a[j] << " ";
	}
	cout << endl;
	copy(a.begin(), a.end(), b.begin());											//����a���������ݵ�b
	copy(a.begin(), a.end(), ostream_iterator<char>(cout, " "));					//�������a������
	cout << endl;
	reverse_copy(b.begin(), b.end(), ostream_iterator<char>(cout, " "));			//�������b
	cout << endl << a.front() << "," << a.back() << "," << a.operator[](5) << endl;	//�������
	sort(b.begin(), b.end(), greater<char>());										//��������
	copy(b.begin(), b.end(), ostream_iterator<char>(cout, " "));					//�������b������
}