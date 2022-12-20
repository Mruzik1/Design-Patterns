using AbstractFactory;


Devices devices = new Devices("ergo");
ErgoMouse ?mouse = devices.GetMouse() as ErgoMouse;


if (mouse != null)
    Console.WriteLine(mouse.GetErgoShape());