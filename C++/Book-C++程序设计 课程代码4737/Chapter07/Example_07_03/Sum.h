#pragma once
template<typename T, int size = 4>	//���ô��ݳ����е����β���ֵ
class Sum
{
	T m[size];						//���ݳ�Ա
public:
	Sum(T a, T b, T c, T d) {		//���캯��
		m[0] = a; m[1] = b; m[2] = c; m[3] = d;
	}
	T S() {							//��ͳ�Ա����
		return m[0] + m[1] + m[2] + m[3];
	}
};

