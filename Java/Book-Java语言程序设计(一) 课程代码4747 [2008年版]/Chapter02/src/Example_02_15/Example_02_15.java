package Example_02_15;

import javax.swing.*;

public class Example_02_15 {
	public static void main(String[] args) {
		long m, n, k;
		int j; // j用于控制每行输出10个质数，作为已输出质数个数的计数器
		String result = (String) JOptionPane.showInputDialog(null, "请输入一个整数（>2）", "输入对话框", JOptionPane.PLAIN_MESSAGE,
				null, null, null);
		m = Integer.parseInt(result); // 将输入字符串转换成整数
		System.out.print("\t2"); // 输出第一个质数 2
		j = 1; // 已输出1个质数
		for (n = 3L; n <= m; n += 2) { // 对于 3 至 m 的整数逐一考察
			for (k = 3L; k * k <= n; k += 2L) { // 用 3 至 n 的平方根内的奇数 k ,测试对 n 的整除性
				if (n % k == 0) {
					break; // 测试 k 对 n 的整除性，若能整除结束测试
				}
			}
			if (k * k > n) { // 对于所有的 k 都不能整除 n,则 n 是质数
				if (j++ % 10 == 0) {
					System.out.println(); // 每输出10个质数换行
				}
				System.out.print("\t" + n);
			}
		}
	}
}