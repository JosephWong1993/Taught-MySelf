#include<iostream>
using namespace std;
template<typename T>	//ʹ�� typename ��� class
T max_(T m1, T m2) {		//�����ֵ
	return (m1 > m2) ? m1 : m2;
}
template<typename T>	//������д
T min_(T m1, T m2) {		//����Сֵ
	return (m1 < m2) ? m1 : m2;
}
void main() {
	cout << max_("ABC", "ABD") << "," << min_("ABC", "ABD") << ","
		<< min_('W', 'T') << "," << min_(2.0, 5.);
	cout << "\t" << min<double>(8.5, 6) << "," << min(8.5, (double)6) << "," << max((int)8.5, 6);
	cout << "\t" << min<int>(2.3, 8.5) << "," << max<int>('a', 'y') << "," << max<char>(95, 121) << endl;
}