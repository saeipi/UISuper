﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[KSPrefabPath("Prefabs/UI/Effect/Controller/UIThreeDimensionalController")]
public class UIThreeDimensionalController : KSWindow
{
    public Button button_next;

    // Start is called before the first frame update
    void Start()
    {
        button_next.onClick.AddListener(OnNextClick);
    }

    void OnNextClick()
    {
        //KSNavigator.Instance.PushCtrl<UISettingController>(new KSKitConfigure(KSCameraType.ui, KSNavigatorBarType.nomarl));
        KSNavigator.Instance.PushCtrl<UIMagicFireController>(new KSKitConfigure(KSCameraType.ui, KSNavigatorBarType.nomarl));
    }
}