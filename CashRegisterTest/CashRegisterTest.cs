namespace CashRegisterTest
{
	using CashRegister;
	using Moq;
	using Xunit;

	public class CashRegisterTest
	{
		[Fact]
		public void Should_process_execute_printing()
		{
			//given
			SpyPrinter printer = new SpyPrinter();
			var cashRegister = new CashRegister(printer);
			var purchase = new Purchase();
			//when
			cashRegister.Process(purchase);
			//then
			Assert.True(printer.HasPrinted);
			//verify that cashRegister.process will trigger print
		}

		[Fact]
		public void Should_print_called_when_run_process_given_spy_print()
		{
			//given
			var spyPrinter = new Mock<Printer>();
			var cashRegister = new CashRegister(spyPrinter.Object);
			var purchase = new Purchase();
			//when
			cashRegister.Process(purchase);
            //then
			spyPrinter.Verify(_ => _.Print(It.IsAny<string>()));
			//verify that cashRegister.process will trigger print
		}
	}
}
