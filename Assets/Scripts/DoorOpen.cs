using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DoorOpen : MonoBehaviour
{
    public Animator animator;
    public TextMeshProUGUI PressE;

    public bool open;


    private void OnTriggerStay(Collider other)
    {
        animator = other.GetComponent<Animator>();
        if (!open)
        {
            if (other.tag == "door")
            {
                PressE.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    open = !open;
                    animator.SetBool("isOpen_Obj_1", true);
                    animator.enabled = true;
                }
            }
        }
        else
        {
            if (other.tag == "door")
            {
                PressE.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    open = !open;
                    animator.SetBool("isOpen_Obj_1", false);
                    animator.enabled = true;
                }
            }
        }


    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "door")
        {
            PressE.enabled = false;

        }
    }
}
