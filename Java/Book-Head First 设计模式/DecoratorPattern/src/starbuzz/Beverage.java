package starbuzz;

// Beverage��һ�������࣬������������getDescription��cost()
public abstract class Beverage {
	String description = "Unknown Beverage";

	// getDescription()�Ѿ��ڴ�ʵ���ˣ�����cost()������������ʵ��
	public String getDescription() {
		return description;
	}

	public abstract double cost();
}