using System.Runtime.InteropServices;
using UnityEngine;
using System.Collections;


public static class Haptic
{
#if UNITY_ANDROID && !UNITY_EDITOR
public static AndroidJavaClass unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
public static AndroidJavaObject currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity");
public static AndroidJavaObject vibrator = currentActivity.Call<AndroidJavaObject>("getSystemService", "vibrator");
#else
    public static AndroidJavaClass unityPlayer;
    public static AndroidJavaObject currentActivity;
    public static AndroidJavaObject vibrator;
#endif
    //##############################################################//VibrationsTypes

    public static bool Enabled = true;

    public static void VibrateNormal()
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
#if UNITY_IPHONE || UNITY_ANDROID
            Handheld.Vibrate();
#endif
        }
    }
    public static void LightTaptic()
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
            long duration = 25;
            if (isAndroid())
                vibrator.Call("vibrate", duration);
            else
            {
                TapticManager.ImpactFeedback feedback;
                feedback = TapticManager.ImpactFeedback.Light;
                TapticManager.Impact(feedback);
            }
        }
    }
    public static void MediumTaptic()
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
            long duration = 50;
            if (isAndroid())
                vibrator.Call("vibrate", duration);
            else
            {
                TapticManager.ImpactFeedback feedback;
                feedback = TapticManager.ImpactFeedback.Medium;
                TapticManager.Impact(feedback);
            }
        }
    }
    public static void HeavyTaptic()
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
            long duration = 75;
            if (isAndroid())
                vibrator.Call("vibrate", duration);
            else
            {
                TapticManager.ImpactFeedback feedback;
                feedback = TapticManager.ImpactFeedback.Heavy;
                TapticManager.Impact(feedback);
            }
        }
    }
    public static void VibrateWithDuration(long duration)
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
            if (isAndroid())
                vibrator.Call("vibrate", duration);
            else
            {
                TapticManager.ImpactFeedback feedback;
                feedback = TapticManager.ImpactFeedback.Heavy;
                TapticManager.Impact(feedback);
            }
        }
    }
    //##################################################
    public static void NotificationSuccessTaptic()
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
            long duration = 25;
            if (isAndroid())
                vibrator.Call("vibrate", duration);
            else
            {
                TapticManager.NotificationFeedback feedback;
                feedback = TapticManager.NotificationFeedback.Success;
                TapticManager.Notification(feedback);
            }
        }
    }
    public static void NotificationWarningTaptic()
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
            long duration = 50;
            if (isAndroid())
                vibrator.Call("vibrate", duration);
            else
            {
                TapticManager.NotificationFeedback feedback;
                feedback = TapticManager.NotificationFeedback.Warning;
                TapticManager.Notification(feedback);
            }
        }
    }
    public static void NotificationErrorTaptic()
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
            long duration = 75;
            if (isAndroid())
                vibrator.Call("vibrate", duration);
            else
            {
                TapticManager.NotificationFeedback feedback;
                feedback = TapticManager.NotificationFeedback.Error;
                TapticManager.Notification(feedback);
            }
        }
    }

    public static void SelectionHaptic()
    {
        if(!Enabled){
            return;
        }
        if (SystemInfo.supportsVibration)
        {
            if (isAndroid())
            {
                //any for now
            }
            else
            {
                TapticManager.Selection();
            }
        }
    }
    //###############################################################
    private static bool isAndroid()
    {
#if UNITY_ANDROID && !UNITY_EDITOR
    return true;
#else
        return false;
#endif
    }
}
//TapticManager
public static class TapticManager
{
    public enum NotificationFeedback
    {
        Success,
        Warning,
        Error
    }
    public enum ImpactFeedback
    {
        Light,
        Medium,
        Heavy
    }

    public static void Notification(NotificationFeedback feedback)
    {
        _unityTapticNotification((int)feedback);
    }

    public static void Impact(ImpactFeedback feedback)
    {
        _unityTapticImpact((int)feedback);
    }

    public static void Selection()
    {
        _unityTapticSelection();
    }

    public static bool IsSupport()
    {
        return _unityTapticIsSupport();
    }

#region DllImport

#if UNITY_IPHONE && !UNITY_EDITOR
        [DllImport("__Internal")]
        private static extern void _unityTapticNotification(int type);
        [DllImport("__Internal")]
        private static extern void _unityTapticSelection();
        [DllImport("__Internal")]
        private static extern void _unityTapticImpact(int style);
        [DllImport("__Internal")]
        private static extern bool _unityTapticIsSupport();
#else
    private static void _unityTapticNotification(int type) { }

    private static void _unityTapticSelection() { }

    private static void _unityTapticImpact(int style) { }

    private static bool _unityTapticIsSupport() { return false; }
#endif

#endregion // DllImport
}

