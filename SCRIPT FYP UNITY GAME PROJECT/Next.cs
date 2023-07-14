using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Next : MonoBehaviour
{
    public void NextPage()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

       public void Menupage()
    {
        SceneManager.LoadScene(0);
    }
}