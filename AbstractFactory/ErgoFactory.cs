namespace AbstractFactory
{
    public class ErgoFactory : IFactory
    {
        public Keyboard createKeyboard(string language)
        {
            return createKeyboard(language, "special");
        }

        public Keyboard createKeyboard(string language, string ergoShape)
        {
            ErgoKeyboard keyboard = new ErgoKeyboard(language);
            keyboard.SetShape(ergoShape);

            return keyboard;
        }

        public Mouse createMouse(int speed)
        {
            return createMouse(speed, "special");
        }

        public Mouse createMouse(int speed, string ergoShape)
        {
            ErgoMouse mouse = new ErgoMouse(speed);
            mouse.SetShape(ergoShape);

            return mouse;
        }
    }
}