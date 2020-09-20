/* const函数返回的常量对象与其他常量对象一起使用 */
#include<iostream>
using namespace std;
class ConstFun {
public:
	int f5() const {
		return 5;	//返回常量对象
	}
	int Obj() {
		return 45;
	}
};
void main() {
	ConstFun s;	//一般对象
	const int i = s.f5();			//对象s使用f5()初始化常整数
	const int j = s.Obj();			//对象s使用Obj()初始化常整数
	int x = s.Obj();				//对象s使用Obj()作为整数
	int y = s.f5();					//对象s使用f5()作为整数
	cout << i << " " << j << " "	// => 5 45
		<< x << " " << y;			// => 45 5
	const ConstFun d;				//const对象
	int k = d.f5();					//常量对象d只能调用常成员函数
	cout << " k = " << k << endl;	// => 5
}