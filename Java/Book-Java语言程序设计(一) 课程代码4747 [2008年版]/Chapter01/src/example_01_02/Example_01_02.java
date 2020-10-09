package example_01_02;

import java.applet.*;
import java.awt.*;

public class Example_01_02 extends Applet {
	public void paint(Graphics g) {
		g.setColor(Color.blue); // 设置显示的颜色为blue
		g.drawString("欢迎你学习Java语言。", 30, 20);
		g.setColor(Color.red); // 设置显示的颜色为red
		g.drawString("只要认真学习，多上机实习，一定能学好Java语言", 30, 50);
	}
}