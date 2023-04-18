using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kaitbords : MonoBehaviour
{
    // Start is called before the first frame update

    bool move = true;
    bool left = true;
    public Transform lidotajs;
    void Start()
    {
        StartCoroutine("moves");
    }

     IEnumerator moves() {
     for(;;) {
            if(move)
                move=false;
            else
                move=true;
     
             
         yield return new WaitForSeconds(0.5f);
     }
 }
    void Update()
    {
        while(move){
            if(left)
               lidotajs.position += new Vector3(0.02f, 0, 0); 
            else
               lidotajs.position += new Vector3(-0.02f, 0, 0);
        }


    }
}
