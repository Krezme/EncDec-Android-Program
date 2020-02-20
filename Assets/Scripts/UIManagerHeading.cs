using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerHeading : MonoBehaviour {

    public Text heading;
    public Image buttonBack;

    private RectTransform rtHeading;
    private RectTransform rtButtonBack;

    private int height;
    private int width;

    void Start()
    {
        SettingWandH();
        SettingRectTransformVars();
        SettingPos();
        SettingSize();
        SettingFontSize();
    }

    void SettingWandH()
    {
        height = Screen.height;
        width = Screen.width;
    }

    void SettingRectTransformVars()
    {
        rtHeading = heading.rectTransform;
        rtButtonBack = buttonBack.rectTransform;
    }

    void SettingPos()
    {
        rtHeading.transform.position = new Vector3(width / 2, height - (height / 8.70f), 0);

        rtButtonBack.transform.position = new Vector3(width - (width / 1.128f), height - (height / 16.54f), 0);
    }

    void SettingSize()
    {
        rtHeading.sizeDelta = new Vector2(width / 2.021f, height / 8.27f);

        rtButtonBack.sizeDelta = new Vector2(width / 7.153f, height / 12.723f);
    }

    void SettingFontSize()
    {
        heading.fontSize = height / 24;
    }
}
