package example_01_02;

import java.applet.*;
import java.awt.*;

public class Example_01_02 extends Applet {
	public void paint(Graphics g) {
		g.setColor(Color.blue); // ������ʾ����ɫΪblue
		g.drawString("��ӭ��ѧϰJava���ԡ�", 30, 20);
		g.setColor(Color.red); // ������ʾ����ɫΪred
		g.drawString("ֻҪ����ѧϰ�����ϻ�ʵϰ��һ����ѧ��Java����", 30, 50);
	}
}