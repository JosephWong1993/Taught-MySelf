#pragma once
template<class T>
class Max4
{
	T a, b, c, d;
	T Max(T a, T b) {
		return(a > b) ? a : b;
	}
public:
	Max4(T, T, T, T);
	T Max(void);
};

