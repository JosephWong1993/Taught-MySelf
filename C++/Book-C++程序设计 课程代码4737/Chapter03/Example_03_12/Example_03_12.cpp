/* �������ز�����̬�Ե����� */
#include<iostream>
using namespace std;
double max(double, double);	//2��ʵ�Ͳ����ĺ���ԭ��
int max(int, int);			//2�����β����ĺ���ԭ��
char max(char, char);		//2���ַ��Ͳ����ĺ���ԭ��
int max(int, int, int);		//3�����β����ĺ���ԭ��
void main() {
	cout << max(2.5, 17.54) << " " << max(56, 8) << " " << max('w', 'p') << endl;
	cout << "max(5,9,4) = " << max(5, 9, 4) << " max(5,4,9) = " << max(5, 4, 9) << endl;
}
double max(double m1, double m2) {
	return(m1 > m2) ? m1 : m2;
}
int max(int m1, int m2) {
	return(m1 > m2) ? m1 : m2;
}
char max(char m1, char m2) {
	return (m1 > m2) ? m1 : m2;
}
int max(int m1, int m2, int m3) {
	int t = max(m1, m2);
	return max(t, m3);
}