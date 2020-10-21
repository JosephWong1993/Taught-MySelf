package starbuzz;

// 这是另一种饮料，做法和Espresso一样，只是把Espresso名称改为"House Blend Coffee"，并返回正确的价钱$0.89。
public class HouseBlend extends Beverage {
	public HouseBlend() {
		description = "House Blend Coffee";
	}

	public double cost() {
		return .89;
	}
}
