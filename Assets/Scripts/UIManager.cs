using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour {

	private int height;
	private int width;
	private RectTransform rtText;
	private RectTransform rtButtonEnc;
	private RectTransform rtButtonDec;
    private RectTransform rtButtonHash;
    private RectTransform rtButtonEncMethods;
    private RectTransform rtButtonInfo;

	public Text text;
	public Text textEnc;
	public Text textDec;
    public Text textHash;
    public Text textEncMethods;
	public Image buttonEnc;
	public Image buttonDec;
    public Image buttonHash;
    public Image buttonEncMethods;
    public Image buttonInfo;

	void Start() {
        SettingWandH();
		SettingRectTransformVars();
		SettingPos();
		SettingSize();
		SettingFontSize();
	}

	void SettingWandH() { 
		height = Screen.height;
		width = Screen.width;
	}

	void SettingRectTransformVars() { 
		rtText = text.rectTransform;
		rtButtonEnc = buttonEnc.rectTransform;
		rtButtonDec = buttonDec.rectTransform;
        rtButtonHash = buttonHash.rectTransform;
        rtButtonEncMethods = buttonEncMethods.rectTransform;
        rtButtonInfo = buttonInfo.rectTransform;
	}

	void SettingPos() {
		rtText.transform.position = new Vector3(width / 2, height - (height / 6.891f), 0);
		rtButtonEnc.transform.position = new Vector3(width / 2, height - (height / 3.348f), 0);
		rtButtonDec.transform.position = new Vector3(width / 2, height - (height / 2.193f), 0);
        rtButtonHash.transform.position = new Vector3(width / 2, height - (height / 1.637f), 0);
        rtButtonEncMethods.transform.position = new Vector3(width / 2, height - (height / 1.294f), 0);
        rtButtonInfo.transform.position = new Vector3(width - (width / 8.77f), height - (height / 20.936f), 0);
    }

	void SettingSize() {
		rtText.sizeDelta = new Vector2(width / 1.16f, height / 8.68f);
		rtButtonEnc.sizeDelta = new Vector2(width / 1.50f, height / 9.0f);
		rtButtonDec.sizeDelta = new Vector2(width / 1.50f, height / 9.0f);
        rtButtonHash.sizeDelta = new Vector2(width / 1.50f, height / 9.0f);
        rtButtonEncMethods.sizeDelta = new Vector2(width / 1.50f, height / 9.0f);
        rtButtonInfo.sizeDelta = new Vector2(width / 7.153f, height / 12.723f);
    }

	void SettingFontSize() {
		text.fontSize = height / 24;
		textEnc.fontSize = height / 26;
		textDec.fontSize = height / 26;
        textHash.fontSize = height / 26;
        textEncMethods.fontSize = height / 26;
    }


}
