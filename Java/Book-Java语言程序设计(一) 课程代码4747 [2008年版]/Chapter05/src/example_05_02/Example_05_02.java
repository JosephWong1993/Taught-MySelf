package example_05_02;

import javax.swing.*;
import java.awt.*;
import java.awt.event.*;

public class Example_05_02 {
	public static MyWindowDemo mw1;
	public static MyWindowDemo mw2;

	public static void main(String args[]) {
		JButton butt1 = new JButton("����һ����ť");
		String name1 = "�ҵĵ�һ������";
		String name2 = "�ҵĵڶ�������";
		mw1 = new MyWindowDemo(name1, butt1, Color.blue, 350, 450);
		mw1.setVisible(true);
		JButton butt2 = new JButton("������һ����ť");
		mw2 = new MyWindowDemo(name2, butt2, Color.magenta, 300, 400);
		mw2.setVisible(true);
	}
}

class MyWindowDemo extends JFrame {
	public MyWindowDemo(String name, JButton button, Color c, int w, int h) {
		super();
		setTitle(name);
		setSize(w, h);
		Container contentPane = getContentPane(); // ��ô����������
		contentPane.add(button); // ����ť��������������
		contentPane.setBackground(c); // ���ñ�����ɫ
	}
}