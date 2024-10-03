using System.Runtime.InteropServices.JavaScript;

namespace BrowserInterop;

public partial class Geolocation
{
    public static void GetCurrentPosition(Action<object> successCallback, Action<string> errorCallback)
    {
        GetCurrentPositionInternal(successCallback, errorCallback);
    }

    [JSImport("globalThis.navigator.geolocation.getCurrentPosition")]
    private static partial void GetCurrentPositionInternal(Action<object> successCallback, Action<string> errorCallback);
}