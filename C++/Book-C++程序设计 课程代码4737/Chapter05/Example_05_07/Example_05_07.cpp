#include<iostream>
using namespace std;
class Base {
private:
	int x;
	const int a;		//�����ݳ�Աֻ��ͨ����ʼ���б�����ó�ֵ
	static const int b;	//��̬�����ݳ�Ա
	const int& r;		//������ֻ��ͨ����ʼ���б�����ó�ֵ
public:
	Base(int, int);
	void Show() {
		cout << x << "," << a << "," << b << "," << r << endl;
	}
	void Display(const double& r) {
		cout << r << endl;
	}
};
const int Base::b = 125;	//��̬�����ݳ�Ա�������ʼ��
Base::Base(int i, int j) :x(i), a(j), r(x) {	//��ʼ���б�
}
void main() {
	Base a1(104, 118), a2(119, 140);
	a1.Show();
	a2.Show();
	a2.Display(3.14159);
}