mergeInto(LibraryManager.library, {
  ShowRewardedAd: function () {
    if (typeof window.ShowRewardedAd === "function") {
      window.ShowRewardedAd();
    } else {
      console.warn("[AdsgramBridge] window.ShowRewardedAd not found, simulating success");
      if (typeof unityInstance !== "undefined") {
        unityInstance.SendMessage("AdManager", "OnRewardedSuccess");
      }
    }
  },

  ShowInterstitialAd: function () {
    if (typeof window.ShowInterstitialAd === "function") {
      window.ShowInterstitialAd();
    } else {
      console.warn("[AdsgramBridge] window.ShowInterstitialAd not found, simulating close");
      if (typeof unityInstance !== "undefined") {
        unityInstance.SendMessage("AdManager", "OnInterstitialClosed");
      }
    }
  }
});
