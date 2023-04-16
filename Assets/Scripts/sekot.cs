using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sekot : MonoBehaviour
{

    public Transform speletajs;

    void LateUpdate() {
        Vector3 jaunaPozicija = speletajs.position;
        jaunaPozicija.y = transform.position.y;
        transform.position = jaunaPozicija;

        transform.rotation = Quaternion.Euler(90f, speletajs.eulerAngles.y, 0f);
    }
}
