using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Encription : MonoBehaviour {

	public Text enterMessige;
	public Text enterFirstCode;
	public Text enterSecondCode;
	public Text encryptedMessige;
	public string[] characters;
	public string[] encriptionCharCode;

	private string messige;
	private long firstPassword;
	private long secondPassword;
	private string[] messigeList;
	private long[] messigeCharCode;
	private string presentingEncMessige;

	public void ButtonOnClick() {
		SettingVariables();
        ConvertingMessigeIntoLetters();
		EncryptionOfMessge();
	}

	void SettingVariables() {
		messige = enterMessige.text;
		messige = messige.ToUpper();

		firstPassword = System.Convert.ToInt32(enterFirstCode.text);
		secondPassword = System.Convert.ToInt32(enterSecondCode.text);
	}

	void ConvertingMessigeIntoLetters() {
		messigeList = new string[messige.Length];
		for (int i = 0; i < messige.Length; i++) {
			messigeList[i] = System.Convert.ToString(messige[i]);
		}
	}

	void EncryptionOfMessge() {
		messigeCharCode = new long[messige.Length];
		for (int i = 0; i < messige.Length; i++)
		{
			messigeCharCode[i] = System.Convert.ToInt64(encriptionCharCode[System.Array.IndexOf(characters, messigeList[i])]);
            //Debug.Log(messigeList[i]);
            //Debug.Log(characters[System.Array.IndexOf(characters, messigeList[i])]);
            //Debug.Log(System.Array.IndexOf(characters, messigeList[i]));
		}

		for (int i = 0; i < messige.Length; i++) {
			messigeCharCode[i] = messigeCharCode[i] * firstPassword;
			messigeCharCode[i] = messigeCharCode[i] * secondPassword;
		}
		presentingEncMessige = null;
		for (int i = 0; i < messige.Length; i++) {
			presentingEncMessige = (presentingEncMessige + " " + messigeCharCode[i]);
		}
		encryptedMessige.text = presentingEncMessige;
		Debug.Log(presentingEncMessige);
		Debug.Log(encryptedMessige);
	}

}
