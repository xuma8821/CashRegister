namespace CashRegister
{
	public class SpyPrinter : Printer
	{
		public bool HasPrinted { get; set; }
		public override void Print(string content)
		{
			HasPrinted = true;
			base.Print(content);
			// send message to a real printer
		}
	}
}
