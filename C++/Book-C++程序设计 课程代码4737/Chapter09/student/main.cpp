#include "student.h"
void main()
{
	vector<student> st;	//����st����������Ϊstudent
	student stud;
	stud.set(st);		//stud���ó�Ա����set�������벢�����ļ�
	cout << "��ʾ����������Ϣ���£�\n";
	stud.display(st);	//��ʾ��������
	cout << "�����ļ��ڵ���Ϣ���£�" << endl;
	stud.read();		//stud����read�����ļ�����
}