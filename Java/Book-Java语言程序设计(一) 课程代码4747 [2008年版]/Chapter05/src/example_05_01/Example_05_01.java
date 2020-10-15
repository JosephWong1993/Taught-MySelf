package example_05_01;

import javax.swing.*;

public class Example_05_01 {
	public static void main(String args[]) {
		JFrame mw = new JFrame("我的第一个窗口"); // 创建一个窗口容器对象
		mw.setSize(250, 200); // 设定窗口的宽和窗口的高，单位是像素
		JButton button = new JButton("我是一个按钮");
		mw.getContentPane().add(button); // 获得窗口的内容面板，并将按钮添加在这个内容面板中
		mw.setVisible(true);
	}
}