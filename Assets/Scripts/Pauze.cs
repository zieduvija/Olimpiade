using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Pauze : MonoBehaviour
{
    public UnityEvent GamePaused;

    public UnityEvent GameResumed;

    private bool _isPaused;

    public GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _isPaused = !_isPaused;

            if (_isPaused)
            {
                Time.timeScale = 0;
                GamePaused.Invoke();
                 AudioListener.pause = true;
                 pauseMenu.SetActive(true);
                   Cursor.lockState = CursorLockMode.None; Cursor.visible = true; 
            }
            else
            {
                Time.timeScale = 1;
                GameResumed.Invoke();
                 AudioListener.pause = false;
                 pauseMenu.SetActive(false);
                  Cursor.lockState = CursorLockMode.Locked;
                   Cursor.visible = false; 
            }
        }
    }

    public void trigger(){
        _isPaused = !_isPaused;
                Time.timeScale = 1;
                GameResumed.Invoke();
                 AudioListener.pause = false;
                 pauseMenu.SetActive(false);
                  Cursor.lockState = CursorLockMode.Locked;
                   Cursor.visible = false; 
    }
}