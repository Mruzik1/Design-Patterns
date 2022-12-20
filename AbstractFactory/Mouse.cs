namespace AbstractFactory
{
    public abstract class Mouse 
    {
        private int speed;

        public Mouse(int speed)
        {
            this.speed = speed;
        }
    }

    public class LEDMouse : Mouse
    {
        private bool isGlowing;

        public bool IsGlowing()
        {
            return isGlowing;
        }

        public LEDMouse(int speed) : base(speed) {}

        public void SetBacklitMode(bool mode)
        {
            isGlowing = mode;
        }
    }

    public class ErgoMouse : Mouse
    {
        private string ergoShape = "regular";

        public string GetErgoShape()
        {
            return ergoShape;
        }

        public ErgoMouse(int speed) : base(speed) {}

        public void SetShape(string shape)
        {
            ergoShape = shape;
        }
    }
}