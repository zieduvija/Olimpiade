using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkritumuRadars : MonoBehaviour
{
    [SerializeField] AudioSource CollectionSound;
    [SerializeField] float checkInterval = 0.09f;
    [SerializeField] float maxDistance = 2.5f;

    private bool ieksa = false;
    private bool atskanojas = false;
    private GameObject speletajs;
    private GameObject paligs;
    private PickUpScript pacelsana;

    private void Start()
    {
        StartCoroutine(DoCheck());
        speletajs = GameObject.FindGameObjectWithTag("Speletajs");
        pacelsana = speletajs.GetComponent<PickUpScript>();
        paligs = GameObject.Find("Paligs");
        if (paligs != null)
            paligs.SetActive(false);
    }

    private IEnumerator DoCheck()
    {
        while (true)
        {
            if (ieksa && atskanojas)
            {
                float dist = Vector3.Distance(gameObject.transform.position, speletajs.transform.position);
                if (dist < maxDistance)
                {
                    CollectionSound.Play();
                    yield return new WaitForSeconds(dist / 8);
                }
            }
            yield return new WaitForSeconds(checkInterval);
        }
    }

    private void Update()
    {
        if (ieksa && gameObject.GetComponent<Rigidbody>().isKinematic)
        {
            atskanojas = false;
            Destroy(gameObject.GetComponent<SphereCollider>());
            CollectionSound.Stop();
        }

        // if (!pacelsana.pacelts && Vector3.Distance(gameObject.transform.position, speletajs.transform.position) < maxDistance && paligs != null)
        // {
        //     paligs.SetActive(true);
        // }
        // else if (paligs != null && !ieksa)
        // {
        //     paligs.SetActive(false);
        // }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Speletajs"))
        {
            ieksa = true;
            atskanojas = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Speletajs"))
        {
            ieksa = false;
            atskanojas = false;
        }
    }
}
