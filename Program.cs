using System;
using System.Threading.Tasks;
using ConsumerAdvice.Services;

namespace ConsumerAdvice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            AdviceService service = new AdviceService();
            var advice = await service.GetAdviceAsync();

            if (advice != null)
            {
                Console.WriteLine($"💡 Conselho do dia: {advice.slip.advice}");
            }
            else
            {
                Console.WriteLine("Não foi possível obter um conselho.");
            }
        }
    }
}
