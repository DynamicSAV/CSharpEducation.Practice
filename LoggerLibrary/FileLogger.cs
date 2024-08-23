namespace LoggerLibrary;

public class FileLogger : ILogger
{
  private readonly string filePath;

  public FileLogger(string filePath)
  {
    this.filePath = filePath;
  }

  public void Log(string message, LogLevel logLevel)
  {
    File.AppendAllText(filePath, $"{DateTime.Now} | {GetType().Name} | {logLevel} | {message}{Environment.NewLine}");
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