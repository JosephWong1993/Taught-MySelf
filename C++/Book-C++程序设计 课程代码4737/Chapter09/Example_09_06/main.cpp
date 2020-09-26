/* 设计类iArray，对其重载下标运算符[]，并能在进行下标访问时检查下标是否越界 */
#include<iostream>
#include<iomanip>
using namespace std;
class iArray {
	int _size;
	int* data;
public:
	iArray(int);
	int& operator[](int);
	int size() const {
		return _size;
	}
	~iArray() {
		delete[] data;
	}
};
iArray::iArray(int n) {	//构造函数中n>1
	if (n < 1) {
		cout << "Error dimension description";
		exit(1);
	}
	_size = n;
	data = new int[_size];
}
int& iArray::operator[](int i) {	//合理范围0~_size-1
	if (i < 0 || i> _size - 1) {
		cout << "\nSubscript out of range";
		delete[] data;	//释放数组所占内存空间
		exit(1);
	}
	return data[i];
}
void main() {
	iArray a(10);
	cout << "数组元素个数 = " << a.size() << endl;
	for (int i = 0; i < a.size(); i++) {
		a[i] = 10 * (i + 1);
	}
	for (int i = 0; i < a.size(); i++) {
		cout << setw(5) << a[i];
	}
}