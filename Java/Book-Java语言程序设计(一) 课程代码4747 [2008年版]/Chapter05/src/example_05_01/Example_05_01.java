package example_05_01;

import javax.swing.*;

public class Example_05_01 {
	public static void main(String args[]) {
		JFrame mw = new JFrame("�ҵĵ�һ������"); // ����һ��������������
		mw.setSize(250, 200); // �趨���ڵĿ�ʹ��ڵĸߣ���λ������
		JButton button = new JButton("����һ����ť");
		mw.getContentPane().add(button); // ��ô��ڵ�������壬������ť�����������������
		mw.setVisible(true);
	}
}