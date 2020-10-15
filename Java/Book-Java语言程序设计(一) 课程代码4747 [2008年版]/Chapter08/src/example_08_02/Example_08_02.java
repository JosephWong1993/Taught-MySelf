package example_08_02;

import java.applet.*;
import java.awt.*;
import javax.swing.*;

public class Example_08_02 extends java.applet.Applet implements Runnable {
	Thread myThread = null; // �����̶߳���
	JTextArea t;
	int k;

	public void start() {
		t = new JTextArea(20, 20);
		add(t);
		k = 0;
		setSize(500, 400);
		if (myThread == null) { // ���½���С����ʱ���ٴδ����߳�myThread
			myThread = new Thread(this); // �������߳�
			myThread.start(); // �������߳�
		}
	}

	// �����̵߳����д���
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
		t.append("���ڹ���������Ϣ��" + k + "��\n");
	}

	// �뿪С����ҳʱ�����ñ����������߳�ֹͣ
	public void stop() {
		if (myThread != null) {
			myThread.stop();
			myThread = null; // ���½���С����ʱ���ٴδ����߳�myThread
		}
	}
}
