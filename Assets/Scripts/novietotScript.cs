using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class novietotScript : MonoBehaviour
{


    public Progress progress;
    [SerializeField]AudioSource CollectionSounds;

    public int score = 0;

    private void OnTriggerEnter(Collider other)
    {
        //if atkritums and not kinetic
        if (other.transform.gameObject.tag == "Atkritums" &&  other.transform.gameObject.GetComponent<Rigidbody>().isKinematic == false)
        {
            score++;
            progress.palielinatProgresu(1f);
            CollectionSounds.Play();
            //Destroy(other.transform.parent.gameObject);
              //other.transform.parent = null;

        }
    }
}
