/* const�������صĳ���������������������һ��ʹ�� */
#include<iostream>
using namespace std;
class ConstFun {
public:
	int f5() const {
		return 5;	//���س�������
	}
	int Obj() {
		return 45;
	}
};
void main() {
	ConstFun s;	//һ�����
	const int i = s.f5();			//����sʹ��f5()��ʼ��������
	const int j = s.Obj();			//����sʹ��Obj()��ʼ��������
	int x = s.Obj();				//����sʹ��Obj()��Ϊ����
	int y = s.f5();					//����sʹ��f5()��Ϊ����
	cout << i << " " << j << " "	// => 5 45
		<< x << " " << y;			// => 45 5
	const ConstFun d;				//const����
	int k = d.f5();					//��������dֻ�ܵ��ó���Ա����
	cout << " k = " << k << endl;	// => 5
}