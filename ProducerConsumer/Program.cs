using System.Collections.Concurrent;

namespace ProducerConsumer
{
    internal class Program
    {
        private static readonly BlockingCollection<int> Buffer = new(10);
        private static readonly CancellationTokenSource CancellationTokenSource = new();

        private static async Task Main(string[] args)
        {
            var producerTask = Task.Run(() => Producer(CancellationTokenSource.Token));
            var consumerTask = Task.Run(() => Consumer(CancellationTokenSource.Token));

            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();
            CancellationTokenSource.Cancel();

            await Task.WhenAll(producerTask, consumerTask);
        }

        private static void Producer(CancellationToken cancellationToken)
        {
            int item = 0;
            while (!cancellationToken.IsCancellationRequested)
            {
                Buffer.Add(item);
                Console.WriteLine($"Produced: {item}");
                item++;
                Thread.Sleep(100); // Simulate work
            }
            Buffer.CompleteAdding();
        }

        private static void Consumer(CancellationToken cancellationToken)
        {
            foreach (var item in Buffer.GetConsumingEnumerable(cancellationToken))
            {
                Console.WriteLine($"Consumed: {item}");
                Thread.Sleep(150); // Simulate work
            }
        }
    }
}