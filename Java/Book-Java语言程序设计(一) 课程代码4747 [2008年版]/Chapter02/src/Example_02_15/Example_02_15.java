package Example_02_15;

import javax.swing.*;

public class Example_02_15 {
	public static void main(String[] args) {
		long m, n, k;
		int j; // j���ڿ���ÿ�����10����������Ϊ��������������ļ�����
		String result = (String) JOptionPane.showInputDialog(null, "������һ��������>2��", "����Ի���", JOptionPane.PLAIN_MESSAGE,
				null, null, null);
		m = Integer.parseInt(result); // �������ַ���ת��������
		System.out.print("\t2"); // �����һ������ 2
		j = 1; // �����1������
		for (n = 3L; n <= m; n += 2) { // ���� 3 �� m ��������һ����
			for (k = 3L; k * k <= n; k += 2L) { // �� 3 �� n ��ƽ�����ڵ����� k ,���Զ� n ��������
				if (n % k == 0) {
					break; // ���� k �� n �������ԣ�����������������
				}
			}
			if (k * k > n) { // �������е� k ���������� n,�� n ������
				if (j++ % 10 == 0) {
					System.out.println(); // ÿ���10����������
				}
				System.out.print("\t" + n);
			}
		}
	}
}