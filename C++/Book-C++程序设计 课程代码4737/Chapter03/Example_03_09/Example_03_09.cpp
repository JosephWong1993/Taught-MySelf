#include<iostream>
using namespace std;
float* input(int&);						//��������ָ��ĺ���
void main() {
	int num;
	float* data;						//������input����һ�µ�ָ��
	data = input(num);					//���ú���������ָ���data
	if (data) {							//data���գ������ָ����
		for (int i = 0; i < num; i++) {	//ʹ��ָ����±���ʽ
			cout << data[i] << " ";		//ѭ�����
		}
		delete data;					//�ͷ��ڴ�ռ�+
	}
}
float* input(int& n) {					//���巵��ָ��ĺ���
	cout << "Input number:";			//ѯ��������������
	cin >> n;
	if (n < 0) return NULL;				//����������������˳�
	float* buf = new float[n];			//����������������ռ�
	if (buf == 0) return NULL;			//û���뵽���˳�
	for (int i = 0; i < n; i++)			//������������
	{
		cin >> buf[i];
	}
	return buf;							//����ָ��
}