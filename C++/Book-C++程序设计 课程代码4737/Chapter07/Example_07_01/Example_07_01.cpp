/* 使用类模板的实例 */
template<class T>						//带参数T的模板声明，可用typename代替class
class TAnyTemp {
	T x, y;								//类型为T的私有数据对象
public:
	TAnyTemp(T X, T Y) :x(X), y(Y) {}	//构造函数
	T getx() {							//内联成员函数，返回类型为T
		return x;
	}
	T gety() {							//内联成员函数，返回类型为T
		return y;
	}
};