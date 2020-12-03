using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    void Exit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }
}
