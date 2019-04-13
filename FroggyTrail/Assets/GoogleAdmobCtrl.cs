using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class GoogleAdmobCtrl : MonoBehaviour {

    private BannerView bannerView;

    void Awake()
    {
        string appId = "ca-app-pub-5023911560716306~3018371852";

        MobileAds.Initialize(appId);
    }

    public void CheckNoAds()
    {
        RequestBanner();
        ShowBannerAd();
    }

    public void ShowBannerAd()
    {
        bannerView.Show();
    }

    public void HideBannerAd()
    {
        bannerView.Hide();
    }

    private void RequestBanner()
    {
        string adUnitId = "ca-app-pub-5023911560716306/2252085091";

        bannerView = new BannerView(adUnitId, AdSize.SmartBanner, AdPosition.Bottom);

        AdRequest request = new AdRequest.Builder().Build();

        bannerView.LoadAd(request);
    }
}
