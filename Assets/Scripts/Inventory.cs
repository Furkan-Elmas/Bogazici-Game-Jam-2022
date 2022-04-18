using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    Animator animator;

    BoxCollider finalDoorCollider;

    public GameObject note1, note2, note3, note4;
    public GameObject screenNote1, screenNote2, screenNote3, screenNote4, screenNote5;
    public GameObject flashLight, body;
    public GameObject finalDoor;
    public GameObject finalDoorLocked;


    public TextMeshProUGUI pressE;
    public TextMeshProUGUI doorisLocked;
    public TextMeshProUGUI takeNote;

    bool haveBag;

    public GameObject invertory;

    int counter = 1;

    private void Start()
    {
        finalDoorCollider = finalDoor.GetComponent<BoxCollider>();
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "door")
        {
            animator = other.GetComponent<Animator>();
        }
        if (other.name == "FinalDoorLocked")
        {
            doorisLocked.enabled = true;
        }
        else if (other.name == "Note1" && animator.enabled && haveBag == true)
        {
            pressE.enabled = true;
            takeNote.enabled = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                note1.SetActive(true);
                Destroy(other.gameObject);
                pressE.enabled = false;
            }
        }
        else if (other.name == "Note2" && animator.enabled && haveBag == true)
        {
            pressE.enabled = true;
            takeNote.enabled = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                note2.SetActive(true);
                Destroy(other.gameObject);
                pressE.enabled = false;
            }
        }
        else if (other.name == "Note3" && animator.enabled && haveBag == true)
        {
            pressE.enabled = true;
            takeNote.enabled = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                note3.SetActive(true);
                Destroy(other.gameObject);
                pressE.enabled = false;
            }
        }
        else if (other.name == "Note4" && animator.enabled && haveBag == true)
        {
            pressE.enabled = true;
            takeNote.enabled = true;
            if (Input.GetKeyDown(KeyCode.R))
            {
                note4.SetActive(true);
                Destroy(other.gameObject);
                pressE.enabled = false;
            }
        }
        if (other.name == "Bag")
        {
            pressE.enabled = true;
            if (Input.GetKeyDown(KeyCode.E))
            {
                flashLight.SetActive(true);
                body.SetActive(true);
                Destroy(other.gameObject);
                pressE.enabled = false;
                haveBag = true;
            }
        }

    }
    private void OnTriggerExit(Collider other)
    {
        pressE.enabled = false;
        doorisLocked.enabled = false;
        takeNote.enabled = false;
    }
    private void LateUpdate()
    {
        if (haveBag && Input.GetKeyDown(KeyCode.I) && counter % 2 != 0)
        {
            invertory.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            counter++;
        }
        else if (haveBag && Input.GetKeyDown(KeyCode.I) && counter % 2 == 0)
        {
            invertory.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            counter++;
        }

        if (note4.activeSelf == false && note3.activeSelf == false && note2.activeSelf == false)
        {
            finalDoorCollider.enabled = false;
            finalDoorLocked.SetActive(true);
        }
        else if (note4.activeSelf == true && note3.activeSelf == true && note2.activeSelf == true)
        {
            finalDoorCollider.enabled = true;
            finalDoorLocked.SetActive(false);
        }

    }

    public void noteRead1()
    {
        screenNote1.SetActive(true);
    }
    public void noteRead2()
    {
        screenNote2.SetActive(true);
    }
    public void noteRead3()
    {
        screenNote3.SetActive(true);
    }
    public void noteRead4()
    {
        screenNote4.SetActive(true);
    }
    public void noteRead5()
    {
        screenNote5.SetActive(true);
    }
    public void noteExit()
    {
        screenNote1.SetActive(false);
        screenNote2.SetActive(false);
        screenNote3.SetActive(false);
        screenNote4.SetActive(false);
        screenNote5.SetActive(false);
    }
}
