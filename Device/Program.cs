using Device;

internal class Program
{
    private static void Main()
    {
        Devices[] devices=
        {
            new Microwave(),
            new Teapot(),
            new Car(),
            new Steamboat()
        };
        foreach (var device in devices)
        {
            device.Show();
            device.Desc();
            device.Sound();
            Console.WriteLine();
        }
    }
}
