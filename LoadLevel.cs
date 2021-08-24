using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadLevel : MonoBehaviour
{
    public string levelname = "enter level name here";

    private void OnTriggerEnter2D(Collider2D other)
    {   
        Test.PlayGame();
    }
}


