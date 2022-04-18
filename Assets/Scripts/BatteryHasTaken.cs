using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryHasTaken : MonoBehaviour
{
    public GameObject battery;
    public GameObject take;

    public bool batteryHasTaken;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "battery")
        {
            take.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E))
            {
                batteryHasTaken = true;
            }
        }
    }
}
