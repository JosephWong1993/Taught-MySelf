/* 功能：将结构对象的两个域值相加，乘以2再加50 */
#include <iostream>	// 包含头文件
using namespace std;

int result(int, int);

const int k = 2;
struct Point {
	int x, y;
};

int main() {
	int z(0), b(50);
	Point a;
	cout << "输入两个整数（以空格区分）：";
	cin >> a.x >> a.y;
	z = (a.x + a.y) * k;
	z = result(z, b);
	cout << "计算结果如下" << endl;
	cout << "（（ " << a.x << " + " << a.y
		<< " ）* " << k << " ）+ " << b
		<< " = " << z
		<< endl;
	return 0;
}

/// <summary>
/// 函  数：result
/// </summary>
/// <param name="a">整形对象 a</param>
/// <param name="b">整形对象 b</param>
/// <returns>整形对象</returns>
int result(int a, int b) {
	return a + b;	// 返回 a + b
}