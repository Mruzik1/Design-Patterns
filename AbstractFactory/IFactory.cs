namespace AbstractFactory
{
    public interface IFactory
    {
        Keyboard createKeyboard(string language);
        Mouse createMouse(int speed);
    }
}