package starbuzz;

// ������һ�����ϣ�������Espressoһ����ֻ�ǰ�Espresso���Ƹ�Ϊ"House Blend Coffee"����������ȷ�ļ�Ǯ$0.89��
public class HouseBlend extends Beverage {
	public HouseBlend() {
		description = "House Blend Coffee";
	}

	public double cost() {
		return .89;
	}
}
