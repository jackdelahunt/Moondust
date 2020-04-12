using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameSession : MonoBehaviour
{
    public void changeScene(string name)
    {
        print("name");

        SceneManager.LoadScene(name);

    }
}
