using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerInfo : MonoBehaviour
{
    private int height;
    private int width;

    public Text content;

    private RectTransform rtContent;

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
        rtContent = content.rectTransform;
    }

    void SettingPos()
    {
        rtContent.transform.position = new Vector3(width / 2, height - (height / 1.654f), 0);
    }

    void SettingSize()
    {
        rtContent.sizeDelta = new Vector2(width / 1.033f, height / 1.272f);
    }

    void SettingFontSize()
    {
        content.fontSize = height / 59;
    }
}

