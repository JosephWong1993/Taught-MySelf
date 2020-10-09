package Example_02_14;

import javax.swing.*;

public class Example_02_14 {

	public static void main(String[] args) {
		int n, j, k, space;
		String result = (String) JOptionPane.showInputDialog(null, "请输入一个整数", "输入对话框", JOptionPane.PLAIN_MESSAGE, null,
				null, null);
		n = Integer.parseInt(result); // 将输入字符串转换为整数
		space = 40; // 设中间位置位于第40个字符位置
		for (j = 0; j <= n; j++, space -= 2) {
			for (int i = 0; i < space; i++)
				System.out.print(" "); // 输出space个空格符
			for (k = 1; k <= 2 * j + 1; k++)
				/* 输出2*j+1个星号 */
				System.out.print(" *");
			System.out.print("\n");
		}
		space += 4; // 下半部的第一行比上半部的最后一行后移两个位置
		for (j = n - 1; j >= 0; j--, space += 2) {
			for (int i = 0; i < space; i++)
				System.out.print(" "); // 输出space个空格符
			for (k = 1; k <= 2 * j + 1; k++)
				System.out.print(" *");
			System.out.print("\n");
		}
	}
}