#include<iostream>
#include<vector>
using namespace std;
void main() {
	char st[11] = "abcdefghij";
	vector<char> a(st, st + 10);								//�������ַ�������Ľ�����־\0
	int j;
	for (j = 0; j < 10; j++) {									//�����������a b c d e f g h i j
		cout << a[j] << " ";
	}
	cout << endl << a.capacity() << "," << a.size() << endl;	//����a��������capacity����size
	a.pop_back();												//ɾ��Ԫ�� j ��size��Ϊ9
	a.push_back('W'); a.push_back('P');							//��β������Ԫ�� W �� P,size��Ϊ 11
	for (j = 0; j < a.size(); j++)								//����������� a b c d e f g h i W P
	{
		cout << a[j] << " ";
	}
	cout << endl << a.capacity() << "," << a.size() << ",";		//size��10��Ϊ11,capacity��10��Ϊ20����VS2019�б�Ϊ15��
	a.clear();													//ɾ��a������Ԫ��
	cout << a.empty() << endl;									//a��û��Ԫ�أ����1
}