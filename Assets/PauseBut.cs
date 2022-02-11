using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBut : MonoBehaviour
{
    public GameObject pause;
    public void PauseGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
    }
}
