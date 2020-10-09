package myPackage;

public class Example_02_13 {
	public static void main(String args[]) {
		int sum = 0, i, j;
		for (i = 2; i <= 100; i++) // 找出100以内的质数
		{
			for (j = 2; j <= i / 2; j++) {
				if (i % j == 0)
					break;
			}
			if (j > i / 2)
				System.out.println("质数：" + i);
		}
	}
}