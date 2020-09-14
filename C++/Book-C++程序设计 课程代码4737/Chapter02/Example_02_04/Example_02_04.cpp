/* 定义类的实例 */
#include<iostream>
using namespace std;
class Point
{
private:
	double x, y;	//类Point的数据成员
public:
	/// <summary>
	/// 类Point的无参数构造函数
	/// </summary>
	Point() {}
	/// <summary>
	/// 具有两个参数的构造函数
	/// </summary>
	Point(double a, double b)
	{
		x = a; y = b;
	}
	/// <summary>
	/// 成员函数，用来重新设置数据成员
	/// </summary>
	void Setxy(double a, double b)
	{
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
	Point a;				//定义类Point的对象a
	Point b(18.5, 10.6);	//定义类Point的对象b并初始化
	a.Setxy(10.6, 18.5);	//为对象a的数据成员赋值
	a.Display();			//显示对象a的数据成员
	b.Display();			//显示对象b的数据成员
}