/* ���ܣ����ṹ�����������ֵ��ӣ�����2�ټ�50 */
#include <iostream>	// ����ͷ�ļ�
using namespace std;

int result(int, int);

const int k = 2;
struct Point {
	int x, y;
};

int main() {
	int z(0), b(50);
	Point a;
	cout << "���������������Կո����֣���";
	cin >> a.x >> a.y;
	z = (a.x + a.y) * k;
	z = result(z, b);
	cout << "����������" << endl;
	cout << "���� " << a.x << " + " << a.y
		<< " ��* " << k << " ��+ " << b
		<< " = " << z
		<< endl;
	return 0;
}

/// <summary>
/// ��  ����result
/// </summary>
/// <param name="a">���ζ��� a</param>
/// <param name="b">���ζ��� b</param>
/// <returns>���ζ���</returns>
int result(int a, int b) {
	return a + b;	// ���� a + b
}