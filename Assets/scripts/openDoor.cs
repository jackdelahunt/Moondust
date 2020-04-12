using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    [SerializeField]Animator doorAnimation;
    [SerializeField] Animator fadeAnimation;

    gameSession session;

    private void Start()
    {
        session = GameObject.FindObjectOfType<gameSession>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("key")) {
            doorAnimation.SetTrigger("keyFound");
            fadeAnimation.SetTrigger("keyFound");
            Invoke("nextScene", 6f);
        }

    }

    private void nextScene() { 
        session.changeScene("interior");
    }

}
