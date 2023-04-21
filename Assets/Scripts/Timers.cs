using UnityEngine;
using System.Collections;

public class Timers : MonoBehaviour
{
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        // Update timer display or do other things with the time elapsed
    }

    public float GetTimeElapsed()
    {
        return Time.time - startTime;
    }
}
