using UnityEngine;
using System.Collections;

public class Timers : MonoBehaviour
{

    public float GetTimeElapsed()
    {
        return GameObject.FindObjectOfType<Laiks>().GetElapsedTime();
    }
}
