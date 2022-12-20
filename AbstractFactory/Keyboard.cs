namespace AbstractFactory
{
    public abstract class Keyboard 
    {
        private string language;

        public Keyboard(string language)
        {
            this.language = language;
        }
    }

    public class LEDKeyboard : Keyboard
    {
        private bool isGlowing = false;

        public bool IsGlowing()
        {
            return isGlowing;
        }

        public LEDKeyboard(string language) : base(language) {}

        public void SetBacklitMode(bool mode)
        {
            isGlowing = mode;
        }
    }

    public class ErgoKeyboard : Keyboard
    {
        private string ergoShape = "regular";

        public string GetErgoShape()
        {
            return ergoShape;
        }

        public ErgoKeyboard(string language) : base(language) {}

        public void SetShape(string shape)
        {
            ergoShape = shape;
        }
    }
}