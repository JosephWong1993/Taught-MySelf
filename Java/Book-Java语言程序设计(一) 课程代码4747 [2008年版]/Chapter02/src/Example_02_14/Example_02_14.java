package Example_02_14;

import javax.swing.*;

public class Example_02_14 {

	public static void main(String[] args) {
		int n, j, k, space;
		String result = (String) JOptionPane.showInputDialog(null, "������һ������", "����Ի���", JOptionPane.PLAIN_MESSAGE, null,
				null, null);
		n = Integer.parseInt(result); // �������ַ���ת��Ϊ����
		space = 40; // ���м�λ��λ�ڵ�40���ַ�λ��
		for (j = 0; j <= n; j++, space -= 2) {
			for (int i = 0; i < space; i++)
				System.out.print(" "); // ���space���ո��
			for (k = 1; k <= 2 * j + 1; k++)
				/* ���2*j+1���Ǻ� */
				System.out.print(" *");
			System.out.print("\n");
		}
		space += 4; // �°벿�ĵ�һ�б��°벿�����һ�к�������λ��
		for (j = n - 1; j >= 0; j--, space += 2) {
			for (int i = 0; i < space; i++)
				System.out.print(" "); // ���space���ո��
		}
		for (k = 1; k <= 2 * j + 1; k++)
			System.out.print(" *");
		System.out.print("\n");
	}
}
