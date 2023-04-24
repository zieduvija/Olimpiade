using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
 using System;

    public class nakamais : MonoBehaviour
    {

     public ScoreManager scoreManager;
     public TMP_InputField nameInputField;
     public Timers timers;
        public int skaitlis = 0;
        public void limenis(){

             if(skaitlis == 10)
             {
                 Application.Quit();
             }else SceneManager.LoadScene(skaitlis);
        }

public void EndGame(){
    SceneManager.LoadScene(skaitlis);
    if (timers != null && nameInputField != null && scoreManager != null) {
        float timeTotal = timers.GetTimeElapsed();
        Debug.Log("Name: "+nameInputField.text+", Time: "+timeTotal);
        Score score = new Score(nameInputField.text, timeTotal);
        scoreManager.AddScore(score);
    } else {
        Debug.LogError("One of the objects (timers, nameInputField or scoreManager) is null!");
    }
}

    }
