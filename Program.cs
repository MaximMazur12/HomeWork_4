using HomeWork4;

string str = PasswordGenerator.Generate(3);  // перевірка чи генерується пароль
Console.WriteLine($"Random password is: " + str);

public class DataBaseEngine
{
    public void WriteValue<T>(T value, string password)
    {
        DataBaseValue<T> baseValue = new DataBaseValue<T>();
    }

    public class DataBaseValue<T>
    {
        public T Value { get; set; }
        public string TableName { get; set; }
    }
}
