using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartMenu : MonoBehaviour
{
    
    public LimenuIzvele izvele;
    public void StartGame(){
        GameObject.FindObjectOfType<Laiks>().ResetTimer();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void Play(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+izvele.level);
        Debug.Log(izvele.level);
    }
}

