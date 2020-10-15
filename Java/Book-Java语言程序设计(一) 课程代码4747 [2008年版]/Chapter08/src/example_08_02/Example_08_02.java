package example_08_02;

import java.applet.*;
import java.awt.*;
import javax.swing.*;

public class Example_08_02 extends java.applet.Applet implements Runnable {
	Thread myThread = null; // 声明线程对象
	JTextArea t;
	int k;

	public void start() {
		t = new JTextArea(20, 20);
		add(t);
		k = 0;
		setSize(500, 400);
		if (myThread == null) { // 重新进入小程序时，再次创建线程myThread
			myThread = new Thread(this); // 创建新线程
			myThread.start(); // 启动新线程
		}
	}

	// 定义线程的运行代码
	public void run() {
		while (myThread != null) {
			try {
				myThread.sleep(1000);
				k++;
			} catch (InterruptedException e) {
			}
			repaint();
		}
	}

	public void paint(Graphics g) {
		double i = Math.random();
		if (i < 0.5) {
			g.setColor(Color.yellow);
		} else {
			g.setColor(Color.blue);
		}
		g.fillOval(10, 10, (int) (100 * i), (int) (100 * i));
		t.append("我在工作，已休息了" + k + "次\n");
	}

	// 离开小程序页时，调用本方法，让线程停止
	public void stop() {
		if (myThread != null) {
			myThread.stop();
			myThread = null; // 重新进入小程序时，再次创建线程myThread
		}
	}
}
