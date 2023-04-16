using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class novietotScript : MonoBehaviour
{
    // Start is called before the first frame update


    int score = 0;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Atkritums")
        {
           Destroy(other.transform.gameObject);
            score++;
            Debug.Log(score.ToString());
            

        }
    }
}
