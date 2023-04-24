using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class liktSkanu : MonoBehaviour
{

    public AudioMixer Skana;
    public void liktLimeni(float sliderValue)
    {
        Skana.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }
}
