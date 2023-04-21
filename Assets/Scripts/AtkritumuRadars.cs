using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkritumuRadars : MonoBehaviour
{
    // Start is called before the first frame update
      [SerializeField]AudioSource CollectionSound;
      bool ieksa = false;
      bool atskanojas = false;
      //float distance = 0.09f;

      public GameObject atkritums;
      public GameObject speletajs;
      private GameObject paligs;
      public PickUpScript pacelsana;

      

      float dist = 0.09f;
    void Start()
    {
         StartCoroutine("DoCheck");
         atkritums = gameObject;
         paligs = GameObject.Find("Paligs");
         dist = Vector3.Distance(atkritums.transform.position, speletajs.transform.position);
         if(paligs != null)
         paligs.SetActive(false);

    }
     IEnumerator DoCheck() {
     for(;;) {
         // execute block of code here
        if (ieksa && atskanojas)
        {
            dist = Vector3.Distance(atkritums.transform.position, speletajs.transform.position);
            //Debug.Log(dist);
            CollectionSound.Play();
        }
             
         yield return new WaitForSeconds(dist/8);
     }
 }


    // Update is called once per frame
    void Update()
    {
        if (ieksa && atkritums.GetComponent<Rigidbody>().isKinematic)
        {
            atskanojas = false;
            atkritums.GetComponent<SphereCollider>().enabled = false;
            CollectionSound.Stop();
        }


        if (!pacelsana.pacelts && dist < 2.5f && paligs != null)
        {
            paligs.SetActive(true);

        } else if(paligs != null)
           

        if(!ieksa && paligs != null)
            paligs.SetActive(false);
        

    }


  
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.gameObject.tag == "Speletajs")
        {
           ieksa = true;
           atskanojas = true;
           //Debug.Log("ieksa");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.gameObject.tag == "Speletajs")
        {
           ieksa = false;
           atskanojas = false;

        }
    }


}
