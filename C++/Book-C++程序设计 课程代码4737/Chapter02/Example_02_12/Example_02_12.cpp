/* ��ʾstring����ʹ�ó�Ա������ʾ�洢���������. */
#include<iostream>
#include<string>
#include<algorithm>
#include<functional>
using namespace std;
void main() {
	string str1 = "wearehere!", str2(str1);									//ʹ��str1��ʼ��str2
	reverse(str1.begin(), str1.end());										//�ַ���Ԫ������
	cout << str1 << endl;
	copy(str1.begin(), str1.end(), str2.begin());							//ԭ�����Ƶ�str2,str2Ӧ������str1
	sort(str1.begin(), str1.end());											//Ĭ����������
	cout << str1 << endl;													//���������
	cout << str2 << endl;													//����ַ���str2������
	reverse_copy(str1.begin(), str1.end(), str2.begin());					//�����Ƶ��ַ���str2
	cout << str2 << endl;													//���������str2������

	reverse(str2.begin() + 2, str2.begin() + 8);							//�ַ���str2��������
	copy(str2.begin() + 2, str2.begin() + 8, ostream_iterator<char>(cout));	//��������Ĳ�������
	cout << endl;

	sort(str1.begin(), str1.end(), greater<char>());						//��������
	cout << str1 << endl;													//����������ִ�str1
	str1.swap(str2);														//���ཻ������
	cout << str1 << " " << str2 << endl;
	cout << (*find(str1.begin(), str1.end() - 1, 'e') == 'e') << " "			//ע�ⲻ�ǳ�Ա����find
		<< (*find(str1.begin(), str1.end() - 1, 'O') == 'O') << endl;
}