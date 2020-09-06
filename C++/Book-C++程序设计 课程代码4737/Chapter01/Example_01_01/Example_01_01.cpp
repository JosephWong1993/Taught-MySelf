/* 功能：将结构对象的两个域值相加，乘以2再加50 */
#include <iostream>							//包含头文件
using namespace std;						//使用命名空间
int result(int, int);						//result函数的原型声明
const int k = 2;							//定义常量
struct Point {								//定义结构point
	int x, y;								//定义结构成员 x 和 y
};

int main()									//主程序
{											//主程序开始
	int z(0), b(50);						//初始化整数对象
	Point a;								//定义结构体对象a
	cout << "输入两个整数（以空格区分）：";	//输出提示信息
	cin >> a.x >> a.y;						//接受输入数值
	z = (a.x + a.y) * k;					//计算结果0
	z = result(z, b);						//计算结果
	cout << "计算结果如下" << endl;			//输出信息并换行
	cout << "（（ " << a.x << " + " << a.y	//输出信息
		<< " ）* " << k << " ）+ " << b		//输出信息
		<< " = " << z						//输出信息
		<< endl;							//换行
	return 0;								//主函数main的返回值
}											//主函数结束
// ******************************
// * 函  数：result				*
// * 参  数：整形对象 a 和 b		*
// * 返回值：整形对象			*
// ******************************
int result(int a, int b) {
	return a + b;							// 返回 a + b
}