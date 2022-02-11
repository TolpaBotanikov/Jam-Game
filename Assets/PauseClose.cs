using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseClose : MonoBehaviour
{
    public GameObject game;
    public void Close()
    {
        game.SetActive(true);
        Time.timeScale = 1f;
    }
}
