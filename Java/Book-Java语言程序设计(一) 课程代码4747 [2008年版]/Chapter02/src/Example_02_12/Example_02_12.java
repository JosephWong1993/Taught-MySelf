package Example_02_12;

public class Example_02_12 {

	public static void main(String[] args) {
		int i, j;
		for (j = 2; j <= 50; j++) { // ��50���ڵ�����
			for (i = 2; i <= j / 2; i++) {
				if (j % i == 0)
					break;
			}
			if (i > j / 2) { // ��2��ʼ��j/2����������j
				System.out.println("\t" + j + "������");
			} else { // �ղ���
			}
		}
	}
}