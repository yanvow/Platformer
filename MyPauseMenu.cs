using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MyPauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject PauseMenuUI;

    public Animator anim;

    public GameObject countDown;

    //public bool waiting_end_state = false;

    //public bool anim_finished = false;

    private void Start()
    {
        countDown.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {

                CountDownBegin();

            }
            else
            {
                Pause();
            }
        }
    }

    

    public void CountDownBegin()
    {    
        PauseMenuUI.SetActive(false);
        Debug.Log("CountDownBegin");
        countDown.SetActive(true);
        anim.Play("CountDown");
    }

    public void CountDownEnd()
    {
        countDown.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    //public void check_state()
    //{

    //    if (!anim.GetCurrentAnimatorStateInfo(0).IsName("CountDown"))
    //    {
    //        waiting_end_state = false;
    //        anim_finished =true;
    //    }
    //}


    public void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    public void ExitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
