#include "student.h"
/****************************/
/* ��Ա����	��display������	*/
/* �Ρ�����	���������������	*/
/* �� �� ֵ	����				*/
/* ��������	�����������Ϣ	*/
/****************************/
void student::display(vector<student>& c)
{
	cout << "ѧ��" << setw(20) << "�ɼ�" << endl;
	for (int i = 0; i < c.size(); i++)	//ѭ����ʾ�����������Ϣ
	{
		cout << c[i].GetNum() << setw(12) << c[i].GetScore() << endl;
	}
}
/********************************************/
/* ��Ա����	��set������						*/
/* �Ρ�����	���������������					*/
/* �� �� ֵ	����								*/
/* ��������	��Ϊ������ֵ�����������ݴ����ļ�	*/
/********************************************/
void student::set(vector<student>& c)
{
	student a;									//�������a��Ϊ������ʱ�洢
	string s;									//������ʱ�洢����ѧ�ŵĶ���
	double b;									//������ʱ�洢����ɼ��Ķ���
	while (1)									//��������
	{
		cout << "ѧ�ţ�";
		cin >> s;								//ȡ��ѧ�Ż��߽�����־
		if (s == "0")
		{
			ofstream wst("stud.txt");			//�����ļ�stud.txt
			if (!wst)							//�ļ�������
			{
				cout << "û����ȷ�����ļ���" << endl;
				return;
			}
			for (int i = 0; i < c.size(); i++)	//���������ݴ����ļ�
			{
				wst << c[i].number << " " << c[i].score << " ";
			}
			wst.close();						//�ر��ļ�
			cout << "һ��д��" << c.size() << "��ѧ������Ϣ��\n";
			return;								//��ȷ�����ļ��󣬽�����������
		}
		a.SetNum(s);							//����ѧ��
		cout << "�ɼ���";
		cin >> b;								//ȡ�óɼ�
		a.Setscore(b);							//����ɼ�
		c.push_back(a);							//��a������׷�ӵ�����c��β��
	}
}
/****************************/
/* ��Ա����	��read			*/
/* �Ρ�����	����				*/
/* �� �� ֵ	����				*/
/* ��������	����ʾ�ļ�����	*/
/****************************/
void student::read()
{
	string number;
	double score;
	ifstream rst("stud.txt");							//���ļ�stud.txt
	if (!rst)											//�ļ�������
	{
		cout << "�ļ��򲻿�\n" << endl;
		return;											//�ļ�����������������
	}
	cout << "ѧ��" << setw(20) << "�ɼ�" << endl;
	while (1)
	{
		rst >> number >> score;
		if (rst.eof())									//�б��Ƿ�����ļ�����
		{
			rst.close();								//������ر��ļ�
			return;										//������������
		}
		cout << number << setw(12) << score << endl;	//��ʾһ����Ϣ
	}
}