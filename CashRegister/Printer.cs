namespace CashRegister
{
	public class Printer
	{
		public bool HasPrinted { get; set; }
		public void Print(string content)
		{
			HasPrinted = true;
			// send message to a real printer
		}
	}
}
