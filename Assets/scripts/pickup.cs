using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pickup : MonoBehaviour
{
    [SerializeField] GameObject hand;
    [SerializeField] Material hoverMaterial;
    GameObject heldObject;
    RaycastHit hit;

    private void FixedUpdate()
    {
        dropItem();

        pickupItem();
    }

    void dropItem()
    {
        if(Input.GetKeyDown("e"))
            if(heldObject != null)
            {
                Rigidbody heldObjectRigidbody = heldObject.GetComponent<Rigidbody>();
                heldObjectRigidbody.useGravity = true;
                heldObject = null;
            }
    }

    void pickupItem()
    {
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        if (heldObject != null)
        {
            heldObject.transform.position = hand.transform.position;
            Rigidbody heldObjectRigidbody = heldObject.GetComponent<Rigidbody>();
            heldObjectRigidbody.useGravity = false;
        }
        else
        {

            if (Physics.Raycast(transform.position, fwd, out hit, 10))
            {
                if (hit.collider.tag == "Item")
                {


                    if (Input.GetKeyDown("e"))
                    {
                        heldObject = hit.collider.gameObject;
                    }
                }
            }
        }
            
    }


}
