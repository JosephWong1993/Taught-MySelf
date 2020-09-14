/* 使结构具有封装性的实例 */
#include<iostream>
using namespace std;
struct Point
{
private:
	double x, y;	//数据成员
public:
	/// <summary>
	/// 成员函数，用来重新设置数据成员
	/// </summary>
	void Setxy(double a, double b)
	{
		x = a;
		y = b;
	}

	void Display()
	{
		cout << x << "\t" << y << endl;
	}
};

void main() {
	Point a;				//定义对象a
	a.Setxy(10.6, 18.5);	//设置对象a的数据成员
	a.Display();			//显示对象a的数据成员
	//cout << a.x << "\t" << a.y << endl;
}