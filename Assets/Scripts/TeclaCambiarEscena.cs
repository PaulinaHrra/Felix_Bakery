using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TeclaCambiarEscena : MonoBehaviour
{
    public string QueEscenaCargar;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            SceneManager.LoadScene(QueEscenaCargar);
        }
    }
}
