using System;
using System.Diagnostics.Metrics;

Console.WriteLine($"Количество доступных логических процессоров: {Environment.ProcessorCount}");
Console.WriteLine("нагружаем процессор... остановить программу когда посмотрите на графики.");
long counter = 0;
while (true)
{
    Counter++;
}

using System.Diagnostics;

#if DEBUG
Console.WriteLine("Режим сборки: Debug");
#else
Console.WriteLine("Режим сборки: Release");
#endif

long counter = 0;
var stopwatch = Stopwatch.StartNew();

while (stopwatch.ElapsedMilliseconds < 1000)
{
    counter++;
}

stopwatch.Stop();
Console.WriteLine($"Количество итераций за секунду: {counter:N0}");

