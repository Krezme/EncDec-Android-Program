using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public void EecriptionLevel()
	{
		SceneManager.LoadScene("Encription");
	}

	public void DecriptionLevel() 
	{ 
		SceneManager.LoadScene("Decription");
	}

    public void HashingLevel() {
        SceneManager.LoadScene("Hashing");
    }

    public void MainMenuLevel() {
        SceneManager.LoadScene("MainMenu");
    }

    public void EncMethodsLevel0() {
        SceneManager.LoadScene("EncMethods0");
    }

    public void InfoLevel() {
        SceneManager.LoadScene("Info");
    }

    public void EncMethodsLevel1() {
        SceneManager.LoadScene("EncMethods1");
    }

    public void EncMethodsLevel2()
    {
        SceneManager.LoadScene("EncMethods2");
    }

}
