#include "Max4.h"
template<typename T>		//�����Ա���������ٴ�����ģ��
Max4<T>::Max4(T x1, T x2, T x3, T x4) :a(x1), b(x2), c(x3), d(x4) {}	
template<typename T>		//�����Ա���������ٴ�����ģ��
T Max4<T>::Max(void) {	//����ʱҪ��Max4<T>��������
	return Max(Max(a, b), Max(c, d));
}