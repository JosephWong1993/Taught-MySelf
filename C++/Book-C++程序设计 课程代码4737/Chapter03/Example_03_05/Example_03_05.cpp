/* ��10��ѧ���ɼ���ƽ��ֵ����ͳ�����в������������Ҫ����һ������ʵ�֣����������������ݸ����ú��������Һ������β�ʹ��������ʵ�� */
#include<iostream>
using namespace std;
typedef double _array[12];			//�Զ��������ʶ��array
void avecount(_array& b, int n) {	//һ������ʹ�����ã�һ������ʹ�ö���
	double ave(0);
	int count(0);					//�ۼ�����ʼ��0
	for (int j = 0; j < n - 2; j++)
	{
		ave = ave + b[j];
		if (b[j] < 60) {
			count++;
		}
	}
	b[n - 2] = ave / (n - 2);		//����ƽ���ɼ�
	b[n - 1] = count;				//���벻��������
}
void main() {
	_array b = { 12,34,56,78,90,98,76,85,64,43 };
	_array& a = b;					//�����������
	avecount(a, 12);				//���ú�������ͳ��
	cout << "ƽ���ɼ�Ϊ" << a[10] << "�֣�������������" << int(a[11]) << "�ˡ�" << endl;
}