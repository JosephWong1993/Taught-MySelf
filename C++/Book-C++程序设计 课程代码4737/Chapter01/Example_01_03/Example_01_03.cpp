//��ʾʹ�� new �� delete �����ӡ�
#include<iostream>
using namespace std;
void main() {
	double* p;						//����double��ָ��
	p = new double[3];				//����3��double�����ݵĴ洢�ռ�
	for (int i = 0; i < 3; i++)		//�������i�ĳ�ֵΪ0
		cin >> *(p + i);			//���������ݴ���ָ����ַ
	for (int i = 0; i < 3; i++)
		cout << *(p + i) << endl;	//����ַ����������
	delete p;
}