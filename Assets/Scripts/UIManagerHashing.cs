using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManagerHashing : MonoBehaviour {

    private int height;
    private int width;

    public Text message;
    public Text submitButtonText;
    public Text subHeading;
    public Text output;

    public Image messageInput;
    public Image submitButton;


    private RectTransform rtMessageInput;
    private RectTransform rtSubmitButton;
    private RectTransform rtSubHeading;
    private RectTransform rtOutput;

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
        rtMessageInput = messageInput.rectTransform;

        rtSubmitButton = submitButton.rectTransform;

        rtSubHeading = subHeading.rectTransform;

        rtOutput = output.rectTransform;
    }

    void SettingPos()
    {
        rtMessageInput.transform.position = new Vector3(width / 2, height - (height / 3.375f), 0);
        rtSubmitButton.transform.position = new Vector3(width / 2, height - (height / 2.176f), 0);
        rtSubHeading.transform.position = new Vector3(width / 2, height - (height / 1.837f), 0);
        rtOutput.transform.position = new Vector3(width / 2, height - (height / 1.318f), 0);
    }

    void SettingSize()
    {
        rtMessageInput.sizeDelta = new Vector2(width / 1.367f, height / 5.012f);
        rtSubmitButton.sizeDelta = new Vector2(width / 1.367f, height / 16.54f);
        rtSubHeading.sizeDelta = new Vector2(width / 1.367f, height / 30.629f);
        rtOutput.sizeDelta = new Vector2(width / 1.367f, height / 2.525f);
    }

    void SettingFontSize()
    {
        message.fontSize = height / 60;
        submitButtonText.fontSize = height / 41;
        subHeading.fontSize = height / 41;
        output.fontSize = height / 55;
    }
}
