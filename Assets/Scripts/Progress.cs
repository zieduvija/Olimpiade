using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Progress : MonoBehaviour
{
    // Start is called before the first frame update
    private Slider slider;
    private ParticleSystem dalinas;


    private float merkaProgress = 0;
    public float atrums = 0.5f;
    private void Awake() {
        slider = gameObject.GetComponent<Slider>();
        dalinas = GameObject.Find("Progress dalinas").GetComponent<ParticleSystem>();
    }
    void Start()
    {
        palielinatProgresu(0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value < merkaProgress)
        {
            slider.value += atrums * Time.deltaTime;   
            if(!dalinas.isPlaying)
                dalinas.Play();
        }
        else
        {
            dalinas.Stop();
        }
                 
    }

    public void palielinatProgresu(float jaunsProgress)
    {
       merkaProgress = slider.value + jaunsProgress;
    }
}