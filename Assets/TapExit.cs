using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapExit : MonoBehaviour
{
    public void Exits()
    {
        Debug.Log("Exit is true");
        Application.Quit();
    }
}
