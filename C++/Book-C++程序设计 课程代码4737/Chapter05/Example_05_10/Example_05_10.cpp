/* ʹ������������ָ������� */
#include<iostream>
using namespace std;

class Test {
	int num;
	double f1;
public:
	Test(int n) {			//һ�������Ĺ��캯��
		num = n;
	}
	Test(int n, double f) {	//���������Ĺ��캯��
		num = n; f1 = f;
	}
	int GetNum() {
		return num;
	}
	double GetF() {
		return f1;
	}
};

void main() {
	Test one[2] = { 2,4 }, * p;
	Test two[2] = {
		Test(1,3.2),
		Test(5,9.5)
	};
	int i;
	for (i = 0; i < 2; i++)	//�����������Ԫ��
	{
		cout << "one[" << i << "] = " << one[i].GetNum() << endl;
	}
	p = two;				//ʹ��ָ�������������Ԫ��
	for (i = 0; i < 2; i++, p++) {
		cout << "two[" << i << "] = (" << p->GetNum() << ","
			<< p->GetF() << ")" << endl;
	}
}