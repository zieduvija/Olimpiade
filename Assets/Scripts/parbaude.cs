using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace parbaude
{
    public class parbaude : MonoBehaviour
    {
        // Start is called before the first frame update
        public Slider progress;
        public TextMeshProUGUI timerText;
        private float secondsCount;
        private int minuteCount;
        void Update(){
            UpdateTimerUI();
            if(progress.value >= 10)
            {
                Debug.Log("uzvar");
                SceneManager.LoadScene(4);
            }
        }
        public void UpdateTimerUI(){
            //set timer UI
            secondsCount += Time.deltaTime;
            timerText.text = minuteCount +":"+(int)secondsCount;
            if(secondsCount >= 60){
                minuteCount++;
                secondsCount = 0;
            }  
        }
    }
    
}

