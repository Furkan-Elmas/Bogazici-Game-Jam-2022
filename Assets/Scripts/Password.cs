using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Password : MonoBehaviour
{
    public GameObject password,startButton, cikisButton;
    int sifre = 8251;
    public TextMeshProUGUI textMeshPro;
    InputField pass;

    private void Start()
    {
        pass = password.GetComponent<InputField>();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "case")
        {
            password.SetActive(true);
            textMeshPro.enabled = true;
            textMeshPro.text = "Þifreyi Gir ve Space'e Bas";
            Cursor.lockState = CursorLockMode.None;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (pass.text == sifre.ToString())
                {
                    textMeshPro.text = "Oyun Bitti!";
                    startButton.SetActive(true);
                    cikisButton.SetActive(true);
                    Time.timeScale = 0;
                }
            }
        }
    }
}
