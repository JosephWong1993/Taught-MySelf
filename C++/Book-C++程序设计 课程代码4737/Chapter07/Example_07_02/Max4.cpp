#include "Max4.h"
template<typename T>		//定义成员函数必须再次声明模板
Max4<T>::Max4(T x1, T x2, T x3, T x4) :a(x1), b(x2), c(x3), d(x4) {}	
template<typename T>		//定义成员函数必须再次声明模板
T Max4<T>::Max(void) {	//定义时要将Max4<T>看做整体
	return Max(Max(a, b), Max(c, d));
}