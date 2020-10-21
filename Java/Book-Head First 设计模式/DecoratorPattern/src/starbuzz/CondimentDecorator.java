package starbuzz;

//首先必须让CondimentDecorator能够取代Beverage，所以得CondimentDecorator扩展自Beverage类
public abstract class CondimentDecorator extends Beverage {
	// 所有的调料装饰者都必须重新实现getDescription()方法
	public abstract String getDescription();
}
