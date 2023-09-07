using UnityEngine;

public static class Vibrator
{
#if UNITY_ANDROID && !UNITY_EDITOR
    public static AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
    public static AndroidJavaObject currentActicity = unityPlayer.GetStatic<AndroidJavaObject>("currentActicity");
    public static AndroidJavaObject vibrator = currentActicity.Call<AndroidJavaObject>("getSystemService", "vibrator");
#else
    public static AndroidJavaClass unityPlayer;
    public static AndroidJavaObject currentActicity;
    public static AndroidJavaObject vibrator;
#endif

    public static void Vibrate(long milliseconds = 250)
    {
        if (IsAndroid())
        {
            vibrator.Call("vibrate", milliseconds);
        }
        else
        {
            Handheld.Vibrate();
        }
    }

    public static void Cancel()
    {
        if (IsAndroid())
        {
            vibrator.Call("cancel");
        }
    }
    public static bool IsAndroid()
    {
#if UNITY_ANDROID&& !UNITY_EDITOR
        return true;
#else
        return false;
#endif
    }
}
