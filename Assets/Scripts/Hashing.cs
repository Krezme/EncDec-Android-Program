using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using UnityEngine.UI;
using UnityEngine;

public class Hashing : MonoBehaviour {

    public Text message;
    public Text outputMessige;

    private string messageString;
    private byte[] messageBytes;
    private SHA256Managed sha;
    private byte[] hash;
    private string messigeHashed;

    public void OnButtonClick() {

        messigeHashed = "";

        messageString = message.text;

        messageBytes = Encoding.UTF8.GetBytes(messageString);

        sha = new SHA256Managed();
        hash = sha.ComputeHash(messageBytes);

        foreach (byte b in hash) {
            messigeHashed = messigeHashed + b.ToString("x2");
        }

        outputMessige.text = messigeHashed;

    }
}
