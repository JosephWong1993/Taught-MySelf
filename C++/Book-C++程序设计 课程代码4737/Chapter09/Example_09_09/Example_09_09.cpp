#include<iostream>
#include<fstream>
using namespace std;
void main() {
	char p_[] = "abcdefg";
	char ch[16], * p = p_;
	ofstream myFile;						//建立输出流myFile
	myFile.open("myTest.txt");				//建立输出流myFile和文件myTest.txt直接的关系
	myFile << p;							//使用输出流myFile将字符串流向文件
	myFile << "GoodBye!";					//使用输出流myFile直接将字符串流向文件
	myFile.close();							//关闭文件myText.txt
	ifstream getText("myTest.txt");			//建立输入流getText及其和文件myText.txt的关联
	int i;
	for (i = 0; i < strlen(p) + 8; i++) {	//使用输入流getText每次从文件myText.txt读入一个字符
		getText >> ch[i];					//将每次读入的1个字符赋给数组的元素ch[i]
	}
	ch[i] = '\0';							//设置结束标志
	getText.close();						//关闭文件myText.txt
	cout << ch;								//使用cout流向屏幕
}