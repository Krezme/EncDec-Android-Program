using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Text.RegularExpressions;

public class Decription : MonoBehaviour
{

    public Text enterMessige;
    public Text enterFirstCode;
    public Text enterSecondCode;
    public Text decriptedMessige;
    public string[] characters;
    public string[] encriptionCharCode;

    private string messigeForDec;
    private string firstCode;
    private string secondCode;
    private string[] encryptedMessage;
    private long[] decryptedCharCodes;
    private string[] decryptedCharacters;

    public void ButtonOnClick()
    {
        SettingVariables();
        SplittingTheEncMessage();
        DecriptingMessage();
    }

    void SettingVariables()
    {
        messigeForDec = enterMessige.text;
        firstCode = enterFirstCode.text;
        secondCode = enterSecondCode.text;
    }

    void SplittingTheEncMessage()
    {
        encryptedMessage = Regex.Split(messigeForDec, " ");
    }

    void DecriptingMessage()
    {
        decryptedCharCodes = new long[encryptedMessage.Length];
        decryptedCharacters = new string[encryptedMessage.Length];
        for (int i = 0; i < encryptedMessage.Length; i++)
        {
            
            decryptedCharCodes[i] = System.Convert.ToInt64(encryptedMessage[i]) / System.Convert.ToInt64(secondCode);
            decryptedCharCodes[i] = decryptedCharCodes[i] / System.Convert.ToInt64(firstCode);
        }
        for (int i = 0; i < decryptedCharCodes.Length; i++)
        {
            Debug.Log(decryptedCharCodes[i]);
            decryptedCharacters[i] = characters[System.Array.IndexOf(encriptionCharCode, System.Convert.ToString(decryptedCharCodes[i]))];
            decriptedMessige.text = decriptedMessige.text + decryptedCharacters[i];
        }
    }

}

