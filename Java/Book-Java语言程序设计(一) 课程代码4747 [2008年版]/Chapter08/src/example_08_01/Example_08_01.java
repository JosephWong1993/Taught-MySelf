package example_08_01;

import java.util.Date;

public class Example_08_01 {
	static Athread threadA;
	static Bthread threadB;

	public static void main(String args[]) {
		threadA = new Athread();
		threadB = new Bthread();
		threadA.start();
		threadB.start();
	}
}

class Athread extends Thread {
	public void run() {
		Date timeNow; // Ϊ���������ʱ��ʱ��
		for (int i = 0; i <= 5; i++) {
			timeNow = new Date(); // �õ���ǰʱ��
			System.out.println("���� threadA��" + timeNow.toString());
			try {
				sleep(2000);
			} catch (InterruptedException e) {

			}
		}
	}
}

class Bthread extends Thread {
	public void run() {
		Date timeNow;
		for (int i = 0; i <= 5; i++) {
			timeNow = new Date();
			System.out.println("���� threadB��" + timeNow.toString());
			try {
				sleep(1000);
			} catch (InterruptedException e) {

			}
		}
	}
}