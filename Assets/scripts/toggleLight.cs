using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggleLight : MonoBehaviour
{
    [SerializeField] Light spotLight;
    [SerializeField] AudioSource buttonPress;

    private void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(1))
        {
            buttonPress.Play();

            if (spotLight.enabled)
                spotLight.enabled = false;
            else
            {
                spotLight.enabled = true;
            }
        }
    }
}
