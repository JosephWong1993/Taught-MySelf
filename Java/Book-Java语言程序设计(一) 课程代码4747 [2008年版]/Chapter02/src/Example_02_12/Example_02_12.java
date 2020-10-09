package Example_02_12;

public class Example_02_12 {

	public static void main(String[] args) {
		int i, j;
		for (j = 2; j <= 50; j++) { // 求50以内的质数
			for (i = 2; i <= j / 2; i++) {
				if (j % i == 0)
					break;
			}
			if (i > j / 2) { // 从2开始至j/2都不能整除j
				System.out.println("\t" + j + "是质数");
			} else { // 空操作
			}
		}
	}
}