package example_08_04;

public class Example_08_04 {
	public static void main(String args[]) {
		MyResourceClass mrc = new MyResourceClass();
		Thread[] aThreadArray = new Thread[20];
		System.out.println("\t刚开始的值是：" + mrc.getInfo());
		// 20个线程*每个线程加1000次*每次加50
		System.out.println("\t预期的正确结果是：" + 20 * 1000 * 50);
		System.out.println("\t多个线程正在工作，请稍等！");
		for (int i = 0; i < 20; i++) {
			aThreadArray[i] = new Thread(new MyMultiThreadClass(mrc));
			aThreadArray[i].start();
		}

		WhileLoop: // 等待所有线程结束
		while (true) {
			for (int i = 0; i < 20; i++) {
				if (aThreadArray[i].isAlive()) {
					continue WhileLoop;
				}
			}
			break;
		}
		System.out.println("\t最后的结果是：" + mrc.getInfo());
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
			LocalInteger = UseInteger.getInfo(); // 把值取出来
			LocalInteger += 50;
			try {
				Thread.sleep(10); // 做一些其他的处理
			} catch (InterruptedException e) {
			}
			UseInteger.putInfo(LocalInteger); // 把值存回去
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
