/* 演示对字符数组进行操作的例子 */
#include<iostream>
#include<algorithm>
#include<functional>
using namespace std;
void main() {
	char a[] = "wearehere!", b[11];
	reverse(a, a + 10);									//数组元素逆向
	copy(a, a + 10, ostream_iterator<char>(cout));		//输出逆向后的数组内容
	cout << endl;
	copy(a, a + 11, b);									//原样复制到数组b

	sort(a, a + 10);									//默认升幂排序
	cout << a << endl;									//输出排序结果
	cout << b << endl;									//输出数组b的内容
	reverse_copy(a, a + 10, b);							//逆向复制到数组b
	cout << b << endl;									//输出逆向后的数组b的内容

	reverse(b + 2, b + 8);								//数组b部分逆向
	copy(b + 2, b + 8, ostream_iterator<char>(cout));	//输出数组b逆向后的部分内容
	cout << endl;

	sort(a, a + 10, greater<char>());					//降幂排序
	cout << a << endl;									//输出排序后的数组a
	cout << (*find(a, a + 10, 'e') == 'e') << " "
		<< (*find(a, a + 10, 'O') == 'O') << endl;
}