using System.Runtime.InteropServices;

internal static class Program
{
    [DllImport("user32.dll")]
    private static extern void keybd_event(
        byte bVk,
        byte bScan,
        uint dwFlags,
        nuint dwExtraInfo);

    private const int KEYEVENTF_KEYUP = 0x0002;

    // Virtual key codes
    private const byte VK_SHIFT = 0x10;
    private const byte VK_F15 = 0x7E;

    private static readonly Random Random = new();

    static async Task Main()
    {
        Console.WriteLine("KeepAwake started.");
        Console.WriteLine("Press Ctrl+C to exit.");

        while (true)
        {
            SendShiftF15();

            int delaySeconds = Random.Next(45, 85);

            Console.WriteLine(
                $"Sent Shift+F15 at {DateTime.Now:T}. " +
                $"Next trigger in {delaySeconds} seconds.");

            await Task.Delay(TimeSpan.FromSeconds(delaySeconds));
        }
    }

    private static void SendShiftF15()
    {
        // Press SHIFT
        keybd_event(VK_SHIFT, 0, 0, 0);

        // Press F15
        keybd_event(VK_F15, 0, 0, 0);

        // Release F15
        keybd_event(VK_F15, 0, KEYEVENTF_KEYUP, 0);

        // Release SHIFT
        keybd_event(VK_SHIFT, 0, KEYEVENTF_KEYUP, 0);
    }
}