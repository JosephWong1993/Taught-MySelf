/* 使用构造函数初始化对象的实例 */
#include<iostream>
using namespace std;
struct Point
{
private:
	double x, y;	//数据成员
public:
	/// <summary>
	/// 无参数构造函数
	/// </summary>
	Point() {}
	/// <summary>
	/// 具有两个参数的构造函数
	/// </summary>
	Point(double a, double b) {
		x = a; y = b;
	}
	/// <summary>
	/// 成员函数，用来重新设置数据成员
	/// </summary>
	void Setxy(double a, double b) {
		x = a; y = b;
	}
	/// <summary>
	/// 成员函数，按指定格式输出数据成员的值
	/// </summary>
	void Display()
	{
		cout << x << "\t" << y << endl;
	}
};

void main() {
	Point a;				//定义对象a
	Point b(18.5, 10.6);	//定义对象b并赋值
	a.Setxy(10.6, 18.5);	//设置变量a的数据成员
	a.Display();			//显示变量a的数据成员
	b.Display();			//显示变量b的数据成员
}