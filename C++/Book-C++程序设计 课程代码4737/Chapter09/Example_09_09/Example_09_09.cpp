#include<iostream>
#include<fstream>
using namespace std;
void main() {
	char p_[] = "abcdefg";
	char ch[16], * p = p_;
	ofstream myFile;						//���������myFile
	myFile.open("myTest.txt");				//���������myFile���ļ�myTest.txtֱ�ӵĹ�ϵ
	myFile << p;							//ʹ�������myFile���ַ��������ļ�
	myFile << "GoodBye!";					//ʹ�������myFileֱ�ӽ��ַ��������ļ�
	myFile.close();							//�ر��ļ�myText.txt
	ifstream getText("myTest.txt");			//����������getText������ļ�myText.txt�Ĺ���
	int i;
	for (i = 0; i < strlen(p) + 8; i++) {	//ʹ��������getTextÿ�δ��ļ�myText.txt����һ���ַ�
		getText >> ch[i];					//��ÿ�ζ����1���ַ����������Ԫ��ch[i]
	}
	ch[i] = '\0';							//���ý�����־
	getText.close();						//�ر��ļ�myText.txt
	cout << ch;								//ʹ��cout������Ļ
}