using System;
using UnityEngine;
using System.Runtime.InteropServices;

public class AdManager : MonoBehaviour
{
    public Action OnRewardGranted;
    public Action OnInterstitialEffectAllowed;
    public Action<string> OnAdFailedWithReason;

#if UNITY_WEBGL && !UNITY_EDITOR
    [DllImport("__Internal")] private static extern void ShowRewardedAd();
    [DllImport("__Internal")] private static extern void ShowInterstitialAd();
#endif
    
    public void ShowRewarded()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        ShowRewardedAd();
#else
        OnRewardedSuccess();
#endif
    }

    public void ShowInterstitial()
    {
#if UNITY_WEBGL && !UNITY_EDITOR
        ShowInterstitialAd();
#else
        OnInterstitialSuccess();
#endif
    }
    //CallBacks
    public void OnRewardedSuccess() => OnRewardGranted?.Invoke();
    
    public void OnRewardedError(string reason) => OnAdFailedWithReason?.Invoke(reason);
    
    public void OnInterstitialSuccess() => OnInterstitialEffectAllowed?.Invoke();
    
    public void OnInterstitialError(string reason) => OnAdFailedWithReason?.Invoke(reason);
}