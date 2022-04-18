using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SahneGecis : MonoBehaviour
{
    public void basla()
    {
        SceneManager.LoadScene(1);
    }
    public void cikis()
    {
        Application.Quit();
    }
}
