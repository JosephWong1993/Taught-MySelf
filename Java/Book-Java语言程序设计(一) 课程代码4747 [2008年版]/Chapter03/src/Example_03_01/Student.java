package Example_03_01;

public class Student {
	float height, weight; // ��Ա��������
	String name, sex, no; // ��Ա��������

	void setStudent(String n, String s, String o) { // ��������
		name = n;
		sex = s;
		no = o;
		System.out.println("������" + name);
		System.out.println("�Ա�" + sex);
		System.out.println("ѧ�ţ�" + no);
	}

	void setWH(float w, float h) { // ��������
		weight = w;
		height = h;
	}
}
