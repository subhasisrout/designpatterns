// See https://aka.ms/new-console-template for more information
using Singleton;

Console.Title = "Singleton pattern";

Logger logger1 = Logger.Instance;
Logger logger2 = Logger.Instance;
Console.WriteLine(logger2 == logger1 ? "Both pointing to same instance" : "Both pointing to differnt instance");
logger1.Log($"Hello from {nameof(logger1)}");
logger2.Log($"Hello from {nameof(logger2)}");
Logger.Instance.Log($"Hello from {nameof(Logger.Instance)}");