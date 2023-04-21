using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


namespace rezultats{
public class rezultats : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public Sprite star;

    public Timers timer;
    int seconds = 0;

    public Image star1, star2, star3, star4, star5;
    void Start()
    {
         seconds = (int)timer.GetTimeElapsed();
        if(seconds >= 60)
        {
            int minutes = seconds / 60;
            int secondsLeft = seconds % 60;
            timerText.text = minutes + ":" + secondsLeft;
        }
        else
        timerText.text = "0:" + seconds;

        if(seconds <= 60)
        {
            star1.gameObject.GetComponent<Image>().sprite = star;
            star2.gameObject.GetComponent<Image>().sprite = star;
            star3.gameObject.GetComponent<Image>().sprite = star;
            star4.gameObject.GetComponent<Image>().sprite = star;
            star5.gameObject.GetComponent<Image>().sprite = star;
        }
        else if(seconds <= 90)
        {
            star1.gameObject.GetComponent<Image>().sprite = star;
            star2.gameObject.GetComponent<Image>().sprite = star;
            star3.gameObject.GetComponent<Image>().sprite = star;
            star4.gameObject.GetComponent<Image>().sprite = star;
        }
        else if(seconds <= 120)
        {
            star1.gameObject.GetComponent<Image>().sprite = star;
            star2.gameObject.GetComponent<Image>().sprite = star;
            star3.gameObject.GetComponent<Image>().sprite = star;
        }
        else if(seconds <= 150)
        {
            star1.gameObject.GetComponent<Image>().sprite = star;
            star2.gameObject.GetComponent<Image>().sprite = star;
        }
        else
        {
            star1.gameObject.GetComponent<Image>().sprite = star;
        }
        

        
    }

}
}
