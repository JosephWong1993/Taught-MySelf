#include<iostream>
using namespace std;
class Test {
	static int x;						//��̬���ݳ�Ա
	int n;
public:
	Test() {}
	Test(int a, int b) {
		x = a;
		n = b;
	}
	static int func() {					//��̬��Ա����
		return x;
	}
	static void sfunc(Test& r, int a) {	//��̬��Ա����
		r.n = a;
	}
	int Getn() {						//�Ǿ�̬��Ա����
		return n;
	}
};
int Test::x = 25;				//��ʼ����̬��������
void main() {
	cout << Test::func();		//x�ڲ�������֮ǰ�����ڣ����25
	Test b, c;
	b.sfunc(b, 58);				//����b��������ݳ�Աn
	cout << " " << b.Getn();
	cout << " " << b.func();	//x�������ж������25
	cout << " " << c.func();	//x�������ж������25
	Test a(24, 26);				//�����xֵ��Ϊ24
	cout << " " << a.func() << " " << b.func() << " " << c.func() << endl;
}