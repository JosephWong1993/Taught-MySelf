package Example_02_10;

public class Example_02_10 {

	public static void main(String[] args) {
		int a, b, c;
		for (c = 3; c <= 25; c++)
			for (b = 1; b < c; b++)
				for (a = 1; a <= b; a++)
					if (a * a + b * b == c * c) {
						System.out.println("A = " + a + "\tB = " + b + "\tC = " + c);
					}
	}
}
