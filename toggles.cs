using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toggles : MonoBehaviour {

    public Toggle infinitRunner;
    public Toggle levels;


    public void MainSceneManager()
    {
        if (infinitRunner.isOn)
        {
            SceneManager.LoadScene("endlesslevel");
        }
        else if(levels.isOn)
        {
            SceneManager.LoadScene("level1");
        }
    }
}
