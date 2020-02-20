using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIManagerEncription : MonoBehaviour
{	
	public Text textEnterMessige;
	public Text textEnterMessigePlaceHolder;
	public Text textEnterFirstCode;
	public Text textEnterFirstCodePlaceHolder;
	public Text textEnterSecondCode;
	public Text textEnterSecondCodePlaceHolder;
	public Text textSubHeading;
	public Text textEncriptedMessige;
	public Text submitButtonText;

	public Image enterMessige;
	public Image enterFirstCode;
	public Image enterSecondCode;
	public Image submitButton;

	private int height;
	private int width;

	private RectTransform rtEnterMessige;
	private RectTransform rtEnterFirstCode;
	private RectTransform rtEnterSecondCode;
	private RectTransform rtTextSubHeading;
	private RectTransform rtTextEncriptedMessige;
	private RectTransform rtSubmitButton;

    public Text heading;
    public Image buttonBack;

    private RectTransform rtHeading;
    private RectTransform rtButtonBack;

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
		rtEnterMessige = enterMessige.rectTransform;

		rtEnterFirstCode = enterFirstCode.rectTransform;

		rtEnterSecondCode = enterSecondCode.rectTransform;

		rtTextSubHeading = textSubHeading.rectTransform;

		rtTextEncriptedMessige = textEncriptedMessige.rectTransform;

		rtSubmitButton = submitButton.rectTransform;

        rtHeading = heading.rectTransform;

        rtButtonBack = buttonBack.rectTransform;
    }

	void SettingPos()
	{
		rtEnterMessige.transform.position = new Vector3 (width / 2, height - (height / 3.504f), 0);

		rtEnterFirstCode.transform.position = new Vector3 (width / 3.9f,height - (height / 2.37f),0);

		rtEnterSecondCode.transform.position = new Vector3(width - (width / 3.9f),height - (height / 2.37f),0);

		rtTextSubHeading.transform.position = new Vector3(width / 2,height - (height / 1.68f),0);

		rtTextEncriptedMessige.transform.position = new Vector3(width / 2,height - (height / 1.28f),0);

		rtSubmitButton.transform.position = new Vector3(width / 2, height - (height / 1.96f),0);

        rtHeading.transform.position = new Vector3(width / 2, height - (height / 8.70f), 0);

        rtButtonBack.transform.position = new Vector3(width - (width / 1.128f), height - (height / 16.54f), 0);
    }

	void SettingSize()
	{
		rtEnterMessige.sizeDelta = new Vector2(width / 1.4f, height / 5.104f);

		rtEnterFirstCode.sizeDelta = new Vector2(width / 2.34f, height / 18.49f);

		rtEnterSecondCode.sizeDelta = new Vector2(width / 2.34f, height / 18.49f);

		rtTextSubHeading.sizeDelta = new Vector2(width / 1.38f, height / 26);

		rtTextEncriptedMessige.sizeDelta = new Vector2(width / 1.38f, height / 2.98f);

        rtSubmitButton.sizeDelta = new Vector2(width / 1.4f, height / 17.6f);

        rtHeading.sizeDelta = new Vector2(width / 2.021f, height / 8.27f);

        rtButtonBack.sizeDelta = new Vector2(width / 7.153f, height / 12.723f);
    }

	void SettingFontSize() { 
		textEnterMessige.fontSize = height / 83;
		textEnterMessigePlaceHolder.fontSize = height / 56;

		textEnterFirstCode.fontSize = height / 56;
		textEnterFirstCodePlaceHolder.fontSize = height / 56;

		textEnterSecondCode.fontSize = height / 56;
		textEnterSecondCodePlaceHolder.fontSize = height / 56;

		textSubHeading.fontSize = height / 41;
		textEncriptedMessige.fontSize = height / 56;

		submitButtonText.fontSize = height / 41;

        heading.fontSize = height / 24;
    }
}
