namespace LoggerLibrary;

public interface ILogger
{
  public void Log(string message, LogLevel logLevel);
  public void Trace(string message);
  public void Info(string message);
  public void Debug(string message);
  public void Warning(string message);
  public void Error(string message);
  public void Fatal(string message);
}