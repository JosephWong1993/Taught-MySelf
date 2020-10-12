package starbuzz;

public class StarbuzzCoffee {
	public static void main(String args[]) {
		// ��һ��Espresso������Ҫ���ϣ���ӡ�����������ͼ�Ǯ
		Beverage beverage = new Espresso();
		System.out.println(beverage.getDescription() + " $" + beverage.cost());

		Beverage beverage2 = new DarkRoast(); // �����һ��DarkRoast����
		beverage2 = new Mocha(beverage2); // ��Mochaװ����
		beverage2 = new Mocha(beverage2); // �õڶ���Mochaװ����
		beverage2 = new Whip(beverage2); // ��whipװ����
		System.out.println(beverage2.getDescription() + " $" + beverage2.cost());

		// �������һ������Ϊ������Ħ�������ݵ�HouseBlend����
		Beverage beverage3 = new HouseBlend();
		beverage3 = new Soy(beverage3);
		beverage3 = new Mocha(beverage3);
		beverage3 = new Whip(beverage3);
		System.out.println(beverage3.getDescription() + " $" + beverage3.cost());
	}
}
