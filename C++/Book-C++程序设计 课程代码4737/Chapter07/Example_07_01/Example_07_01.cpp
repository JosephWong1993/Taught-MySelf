/* ʹ����ģ���ʵ�� */
template<class T>						//������T��ģ������������typename����class
class TAnyTemp {
	T x, y;								//����ΪT��˽�����ݶ���
public:
	TAnyTemp(T X, T Y) :x(X), y(Y) {}	//���캯��
	T getx() {							//������Ա��������������ΪT
		return x;
	}
	T gety() {							//������Ա��������������ΪT
		return y;
	}
};