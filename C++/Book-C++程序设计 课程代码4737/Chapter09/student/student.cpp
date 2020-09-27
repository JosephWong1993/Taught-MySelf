#include "student.h"
/****************************/
/* 成员函数	：display　　　	*/
/* 参　　数	：向量对象的引用	*/
/* 返 回 值	：无				*/
/* 功　　能	：输出向量信息	*/
/****************************/
void student::display(vector<student>& c)
{
	cout << "学号" << setw(20) << "成绩" << endl;
	for (int i = 0; i < c.size(); i++)	//循环显示向量对象的信息
	{
		cout << c[i].GetNum() << setw(12) << c[i].GetScore() << endl;
	}
}
/********************************************/
/* 成员函数	：set　　　						*/
/* 参　　数	：向量对象的引用					*/
/* 返 回 值	：无								*/
/* 功　　能	：为向量赋值并将向量内容存入文件	*/
/********************************************/
void student::set(vector<student>& c)
{
	student a;									//定义对象a作为数据临时存储
	string s;									//定义临时存储输入学号的对象
	double b;									//定义临时存储输入成绩的对象
	while (1)									//输入数据
	{
		cout << "学号：";
		cin >> s;								//取得学号或者结束标志
		if (s == "0")
		{
			ofstream wst("stud.txt");			//建立文件stud.txt
			if (!wst)							//文件出错处理
			{
				cout << "没有正确建立文件！" << endl;
				return;
			}
			for (int i = 0; i < c.size(); i++)	//将向量内容存入文件
			{
				wst << c[i].number << " " << c[i].score << " ";
			}
			wst.close();						//关闭文件
			cout << "一共写入" << c.size() << "个学生的信息。\n";
			return;								//正确存入文件后，结束程序运行
		}
		a.SetNum(s);							//存入学号
		cout << "成绩：";
		cin >> b;								//取得成绩
		a.Setscore(b);							//存入成绩
		c.push_back(a);							//将a的内容追加到向量c的尾部
	}
}
/****************************/
/* 成员函数	：read			*/
/* 参　　数	：无				*/
/* 返 回 值	：无				*/
/* 功　　能	：显示文件内容	*/
/****************************/
void student::read()
{
	string number;
	double score;
	ifstream rst("stud.txt");							//打开文件stud.txt
	if (!rst)											//文件出错处理
	{
		cout << "文件打不开\n" << endl;
		return;											//文件出错，结束程序运行
	}
	cout << "学号" << setw(20) << "成绩" << endl;
	while (1)
	{
		rst >> number >> score;
		if (rst.eof())									//判别是否读完文件内容
		{
			rst.close();								//读完则关闭文件
			return;										//结束程序运行
		}
		cout << number << setw(12) << score << endl;	//显示一条信息
	}
}