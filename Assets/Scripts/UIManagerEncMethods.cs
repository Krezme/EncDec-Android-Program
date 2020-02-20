using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerEncMethods : MonoBehaviour
{
    private int height;
    private int width;

    public Text content;
    public Text nextPageText;
    public Image nextPage;

    private RectTransform rtContent;
    private RectTransform rtNextPage;

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
        rtNextPage = nextPage.rectTransform;
    }

    void SettingPos()
    {
        rtContent.transform.position = new Vector3(width / 2, height - (height / 1.654f), 0);
        rtNextPage.transform.position = new Vector3(width / 1.128f, height - (height / 16.54f), 0);
    }

    void SettingSize()
    {
        rtContent.sizeDelta = new Vector2(width / 1.033f, height / 1.272f);
        rtNextPage.sizeDelta = new Vector2(width / 7.153f, height / 12.723f);
    }

    void SettingFontSize()
    {
        content.fontSize = height / 59;
        nextPageText.fontSize = height / 59;
    }
}

