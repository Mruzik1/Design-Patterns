namespace AbstractFactory
{
    public class Devices
    {
        private IFactory factory;
        private Keyboard keyboard;
        private Mouse mouse;

        public Keyboard GetKeyboard()
        {
            return keyboard;
        }

        public Mouse GetMouse()
        {
            return mouse;
        }

        public Devices(string type)
        {
            if (type == "ergo")
                this.factory = new ErgoFactory();
            else if (type == "led")
                this.factory = new LEDFactory();
            else
                throw new ArgumentException("This type does not exist!");

            this.keyboard = factory.createKeyboard("eng");
            this.mouse = factory.createMouse(1);
        }
    }
}