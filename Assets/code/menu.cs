using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
   public void startbutt()
    {
        SceneManager.LoadScene("1");
    }
    public void exitbutt()
    {
        Application.Quit();
    }
}
