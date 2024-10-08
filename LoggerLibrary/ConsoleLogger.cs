﻿namespace LoggerLibrary;

public class ConsoleLogger : ILogger
{
  public void Log(string message, LogLevel logLevel)
  {
    Console.WriteLine($"{DateTime.Now} | {GetType().Name} | {logLevel} | {message}");
  }

  public void Trace(string message)
  {
    Log(message, LogLevel.Trace);
  }

  public void Info(string message)
  {
    Log(message, LogLevel.Info);
  }

  public void Debug(string message)
  {
    Log(message, LogLevel.Debug);
  }

  public void Warning(string message)
  {
    Log(message, LogLevel.Warning);
  }

  public void Error(string message)
  {
    Log(message, LogLevel.Error);
  }

  public void Fatal(string message)
  {
    Log(message, LogLevel.Fatal);
  }
}