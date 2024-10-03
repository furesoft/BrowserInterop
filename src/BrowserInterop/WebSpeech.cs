using System.Runtime.InteropServices.JavaScript;

namespace BrowserInterop;

public partial class WebSpeech
{
    [JSImport("globalThis.speechSynthesis.speak")]
    public static partial void Speak(string text);

    public static object CreateSpeechRecognition()
    {
        return CreateSpeechRecognitionInternal();
    }

    [JSImport("globalThis.webkitSpeechRecognition")]
    private static partial object CreateSpeechRecognitionInternal();
}