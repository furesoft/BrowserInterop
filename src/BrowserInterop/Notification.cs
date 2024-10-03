using System.Runtime.InteropServices.JavaScript;

namespace BrowserInterop;

public partial class Notification
{
    [JSImport("globalThis.Notification.requestPermission")]
    public static partial Task<string> RequestPermission();

    [JSImport("globalThis.Notification.show")]
    public static partial void Show(string title, object options);
}