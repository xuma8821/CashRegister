namespace CashRegisterTest
{
	using CashRegister;
	using Xunit;

	public class CashRegisterTest
	{
		[Fact]
		public void Should_process_execute_printing()
		{
			//given
			Printer printer = new Printer();
			var cashRegister = new CashRegister(printer);
			var purchase = new Purchase();
			//when
			cashRegister.Process(purchase);
			//then
			Assert.True(printer.HasPrinted);
			//verify that cashRegister.process will trigger print
		}
	}
}
