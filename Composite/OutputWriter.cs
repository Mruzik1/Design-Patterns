public class OutputWriter
{
    static private OutputWriter instance;

    public static OutputWriter GetInstance()
    {
        if (instance == null)
            instance = new OutputWriter();
        return instance;
    }

    private OutputWriter() {}

    public void WriteLine(string line)
    {
        Console.WriteLine(line);
    }
}