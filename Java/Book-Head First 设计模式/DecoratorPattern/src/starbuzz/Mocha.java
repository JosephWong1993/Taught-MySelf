package starbuzz;

// Ħ����һ��װ���ߣ�����������չ��CondimentDecorator��
// �����ˣ�CondimentDecorator��չ��Beverage��
public class Mocha extends CondimentDecorator {
	// Ҫ��Mocha�ܹ�����һ��Beverage���������£�
	// ��1����һ��ʵ��������¼���ϣ�Ҳ���Ǳ�װ���ߡ�
	// ��2����취�ñ�װ���ߣ����ϣ�����¼��ʵ�������С�����������ǣ������ϵ����������Ĳ��������ɹ������������ϼ�¼��ʵ�������С�
	Beverage beverage;
	public Mocha(Beverage beverage) {
		this.beverage = beverage;
	}

	// ����ϣ��������ֻ���������ϣ����硰DarkRoast���������������������϶��������������硰DarkRoast, Mocha������
	// ������������ί�е��������õ�һ��������Ȼ�������ϼ��ϸ��ӵ����������硰Mocha������
	public String getDescription() {
		return beverage.getDescription() + ", Mocha";
	}

	public double cost() {
		return .20 + beverage.cost();
	}
}