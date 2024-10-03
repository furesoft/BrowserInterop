using System.Runtime.InteropServices.JavaScript;

namespace BrowserInterop;

public partial class Navigator
{
    [JSImport("globalThis.navigator.userAgent")]
    public static partial string GetUserAgent();

    [JSImport("globalThis.navigator.language")]
    public static partial string GetLanguage();
}