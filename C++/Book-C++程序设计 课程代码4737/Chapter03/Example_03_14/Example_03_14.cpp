/* ��д�����������е����ֵ�ĺ���ģ����� */
#include<iostream>
using namespace std;
template<class T>
T max_(T m1, T m2) {
	return (m1 > m2) ? m1 : m2;
}
void main() {
	cout << max_(2, 5) << "\t" << max_(2.0, 5.) << "\t"
		<< max_('w', 'a') << "\t" << max_("ABC", "ABD") << endl;
}