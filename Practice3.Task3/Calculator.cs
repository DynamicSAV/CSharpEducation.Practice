namespace Practice3.Task3;

// Создай класс "Калькулятор" с методами для выполнения основных арифметических
// операций (сложение, вычитание, умножение, деление). Пусть эти методы
// принимают два числа и возвращают результат операции.


public class Calculator
{
  public int Add(int firstNum, int secondNum)
  {
    return firstNum + secondNum;
  }

  public int Substract(int firstNum, int secondNum)
  {
    return firstNum - secondNum;
  }
  
  public int Multiply(int firstNum, int secondNum)
  {
    return firstNum * secondNum;
  }

  public float Divide(int firstNum, int secondNum)
  {
    return (float)firstNum / secondNum;
  }
}