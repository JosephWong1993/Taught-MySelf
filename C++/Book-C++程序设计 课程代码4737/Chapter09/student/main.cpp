#include "student.h"
void main()
{
	vector<student> st;	//向量st的数据类型为student
	student stud;
	stud.set(st);		//stud调用成员函数set接受输入并建立文件
	cout << "显示向量数组信息如下：\n";
	stud.display(st);	//显示向量内容
	cout << "存入文件内的信息如下：" << endl;
	stud.read();		//stud调用read读出文件内容
}