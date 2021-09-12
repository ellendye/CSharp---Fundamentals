using System;

namespace IronNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            SweetTooth brad = new SweetTooth();
            SpiceHound ellen = new SpiceHound();
            Buffet myBuff = new Buffet();
            while(brad.IsFull != true){
                brad.Consume(myBuff.Serve());
            }
            while(ellen.IsFull != true){
                ellen.Consume(myBuff.Serve());
            }
            if(ellen.ConsumptionHistory.Count > brad.ConsumptionHistory.Count){
                Console.WriteLine($"{nameof(ellen)} consumed more. They ate {ellen.ConsumptionHistory.Count} items");
            }
            else{
                Console.WriteLine($"{nameof(brad)} consumed more. They ate {brad.ConsumptionHistory.Count} items");
            }
        }
    }
}
