using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeScript : MonoBehaviour
{
    [SerializeField]Animator myAnimator;

    private void Start()
    {
        print("start");
        myAnimator.SetTrigger("start");
    }
}
