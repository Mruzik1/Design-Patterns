namespace AbstractFactory
{
    public class LEDFactory : IFactory
    {
        public Keyboard createKeyboard(string language)
        {
            return createKeyboard(language, true);
        }

        public Keyboard createKeyboard(string language, bool backlitMode)
        {
            LEDKeyboard keyboard = new LEDKeyboard(language);
            keyboard.SetBacklitMode(backlitMode);

            return keyboard;
        }

        public Mouse createMouse(int speed)
        {
            return createMouse(speed, true);
        }

        public Mouse createMouse(int speed, bool backlitMode)
        {
            LEDMouse mouse = new LEDMouse(speed);
            mouse.SetBacklitMode(backlitMode);

            return mouse;
        }
    }
}