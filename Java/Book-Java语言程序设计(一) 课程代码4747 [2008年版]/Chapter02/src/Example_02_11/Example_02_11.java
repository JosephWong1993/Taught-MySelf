package Example_02_11;

public class Example_02_11 {
	public static void main(String[] args) {
		int a, b, c, d;
		boolean t;
		for (a = 1; a <= 4; a++)
			for (b = 1; b <= 4; b++) {
				/* �������β�����ͬ��ȡ��һ��bֵ */
				if (b == a)
					continue;
				for (c = 1; c <= 4; c++) {
					/* ȡ��һ��cֵ */
					if (c == a || c == b)
						continue;
					d = 10 - a - b - c; // �Ķ�����֮��Ϊ10
					t = ((a == 1) != (b == 2)) && ((c == 1) != (d == 3)) && ((d == 2) != (a == 3));
					if (t)
						System.out.println("A = " + a + ",B = " + b + ",C = " + c + ",D = " + d);
				}
			}
	}
}
