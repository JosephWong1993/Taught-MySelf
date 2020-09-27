package Example_02_11;

public class Example_02_11 {
	public static void main(String[] args) {
		int a, b, c, d;
		boolean t;
		for (a = 1; a <= 4; a++)
			for (b = 1; b <= 4; b++) {
				/* 两队名次不可相同，取下一个b值 */
				if (b == a)
					continue;
				for (c = 1; c <= 4; c++) {
					/* 取下一个c值 */
					if (c == a || c == b)
						continue;
					d = 10 - a - b - c; // 四队名次之和为10
					t = ((a == 1) != (b == 2)) && ((c == 1) != (d == 3)) && ((d == 2) != (a == 3));
					if (t)
						System.out.println("A = " + a + ",B = " + b + ",C = " + c + ",D = " + d);
				}
			}
	}
}
