using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {


    public  void PlayGame()
    {
        Test.PlayGame();
    }

	public void ExitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
