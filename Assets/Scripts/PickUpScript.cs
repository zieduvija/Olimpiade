using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour
{
[SerializeField] private AudioSource CollectionSounds;
[SerializeField] private float throwForce = 500f;
[SerializeField] private float pickUpRange = 5f;
[SerializeField] private float rotationSensitivity = 1f;
[SerializeField] private GameObject player;
[SerializeField] private Transform holdPos;
[SerializeField] private LayerMask holdLayer;
private GameObject heldObj;
private Rigidbody heldObjRb;
private bool canDrop = true;
public bool pacelts = false;

void Update()
{
    if (Input.GetKeyDown(KeyCode.E))
    {
        if (heldObj == null)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, pickUpRange))
            {
                Debug.Log("hit");
                if(hit.transform.gameObject.tag == "Atkritums")
                PickUpObject(hit.transform.gameObject);
            }
        }
        else if (canDrop)
        {
            StopClipping();
            DropObject();
        }
    }

    if (heldObj != null)
    {
        MoveObject();
        RotateObject();
        if (Input.GetKeyDown(KeyCode.Mouse0) && canDrop)
        {
            StopClipping();
            ThrowObject();
            CollectionSounds.Play();
        }
    }
}

private void PickUpObject(GameObject pickUpObj)
{
    if (pickUpObj.GetComponent<Rigidbody>())
    {
        pacelts = true;
        heldObj = pickUpObj;
        heldObjRb = pickUpObj.GetComponent<Rigidbody>();
        heldObjRb.isKinematic = true;
        heldObj.transform.SetParent(holdPos);
        // heldObj.layer = holdLayer;
        heldObj.layer = (int)Mathf.Clamp(holdLayer.value, 0, 31);
        Physics.IgnoreCollision(heldObj.GetComponent<Collider>(), player.GetComponent<Collider>(), true);
    }
}

private void DropObject()
{
    pacelts = false;
    Physics.IgnoreCollision(heldObj.GetComponent<Collider>(), player.GetComponent<Collider>(), false);
    heldObj.layer = 0;
    heldObjRb.isKinematic = false;
    heldObj.transform.SetParent(null);
    heldObj = null;
}

private void MoveObject()
{
    heldObj.transform.position = holdPos.position;
}

private void RotateObject()
{
    if (Input.GetKey(KeyCode.R))
    {
        canDrop = false;
        float XaxisRotation = Input.GetAxis("Mouse X") * rotationSensitivity;
        float YaxisRotation = Input.GetAxis("Mouse Y") * rotationSensitivity;
        heldObj.transform.Rotate(Vector3.down, XaxisRotation);
        heldObj.transform.Rotate(Vector3.right, YaxisRotation);
    }
    else
    {
        canDrop = true;
    }
}

private void ThrowObject()
{
    pacelts = false;
    Physics.IgnoreCollision(heldObj.GetComponent<Collider>(), player.GetComponent<Collider>(), false);
    heldObj.layer = 0;
    heldObjRb.isKinematic = false;
    heldObj.transform.SetParent(null);
    heldObjRb.AddForce(transform.forward * throwForce);
    heldObj = null;
}

private void StopClipping()
{
    Collider[] colliders = heldObj.GetComponentsInChildren<Collider>();
    foreach (Collider c in colliders)
    {
        c.enabled = false;
    }
    colliders[0].enabled = true;
}
}
