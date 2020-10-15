package example_08_04;

public class Example_08_04 {
	public static void main(String args[]) {
		MyResourceClass mrc = new MyResourceClass();
		Thread[] aThreadArray = new Thread[20];
		System.out.println("\t�տ�ʼ��ֵ�ǣ�" + mrc.getInfo());
		// 20���߳�*ÿ���̼߳�1000��*ÿ�μ�50
		System.out.println("\tԤ�ڵ���ȷ����ǣ�" + 20 * 1000 * 50);
		System.out.println("\t����߳����ڹ��������Եȣ�");
		for (int i = 0; i < 20; i++) {
			aThreadArray[i] = new Thread(new MyMultiThreadClass(mrc));
			aThreadArray[i].start();
		}

		WhileLoop: // �ȴ������߳̽���
		while (true) {
			for (int i = 0; i < 20; i++) {
				if (aThreadArray[i].isAlive()) {
					continue WhileLoop;
				}
			}
			break;
		}
		System.out.println("\t���Ľ���ǣ�" + mrc.getInfo());
	}
}

class MyMultiThreadClass implements Runnable {
	MyResourceClass UseInteger;

	MyMultiThreadClass(MyResourceClass mrc) {
		UseInteger = mrc;
	}

	public void run() {
		int i, LocalInteger;
		for (i = 0; i < 1000; i++) {
			LocalInteger = UseInteger.getInfo(); // ��ֵȡ����
			LocalInteger += 50;
			try {
				Thread.sleep(10); // ��һЩ�����Ĵ���
			} catch (InterruptedException e) {
			}
			UseInteger.putInfo(LocalInteger); // ��ֵ���ȥ
		}
	}
}

class MyResourceClass {
	int IntegerResource;

	MyResourceClass() {
		IntegerResource = 0;
	}

	public int getInfo() {
		return IntegerResource;
	}

	public void putInfo(int Info) {
		IntegerResource = Info;
	}
}
