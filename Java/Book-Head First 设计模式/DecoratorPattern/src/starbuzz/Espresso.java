package starbuzz;

// ���ȣ���Espresso��չ��Beverage�࣬��ΪEspresso��һ������
public class Espresso extends Beverage {
	public Espresso() {
		// Ϊ��Ҫ�������ϵ�����������д��һ������������ס��descriptionʵ�������̳���Beverage��
		description = "Espresso";
	}

	public double cost() {
		// �����Ҫ����Espresso�ļ�Ǯ�����ڲ���Ҫ�ܵ��ϵļ�Ǯ��ֱ�Ӱ�Espresso�ļ۸�$1.99���ؼ���
		return 1.99;
	}
}