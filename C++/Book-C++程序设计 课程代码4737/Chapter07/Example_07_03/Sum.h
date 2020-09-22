#pragma once
template<typename T, int size = 4>	//可用传递程序中的整形参数值
class Sum
{
	T m[size];						//数据成员
public:
	Sum(T a, T b, T c, T d) {		//构造函数
		m[0] = a; m[1] = b; m[2] = c; m[3] = d;
	}
	T S() {							//求和成员函数
		return m[0] + m[1] + m[2] + m[3];
	}
};

