package Example_03_01;

public class Student {
	float height, weight; // 成员变量定义
	String name, sex, no; // 成员变量定义

	void setStudent(String n, String s, String o) { // 方法定义
		name = n;
		sex = s;
		no = o;
		System.out.println("姓名：" + name);
		System.out.println("性别：" + sex);
		System.out.println("学号：" + no);
	}

	void setWH(float w, float h) { // 方法定义
		weight = w;
		height = h;
	}
}
