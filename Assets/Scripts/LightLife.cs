using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LightLife : MonoBehaviour
{
    public TextMeshProUGUI BatteryText;
    public TextMeshProUGUI PressE;

    public GameObject[] batteries;

    public Light isik, isik2;
    public bool acik;

    [Range(0f, 100f)]
    public float enerji = 100f;

    public int batteryCount;

    public Slider enerji_barý;

    public void Start()
    {
        enerji_barý.maxValue = 100f;
        PlayerPrefs.DeleteAll();
    }

    private void Update()
    {
        enerji_barý.value = enerji;
        if (Input.GetKeyDown(KeyCode.F))
        {
            acik = !acik;
        }
        if (acik)
        {
            isik.enabled = true;
            isik2.enabled = true;
            enerji = enerji - 1 * Time.deltaTime;
        }
        else
        {
            isik.enabled = false;
            isik2.enabled = false;
        }
        if (enerji <= 0)
        {
            enerji = 0;
            isik.enabled = false;
            isik2.enabled = false;
        }
    }
    public bool batteryHasTaken;

    private void OnTriggerStay(Collider other)
    {
        batteryCount = PlayerPrefs.GetInt("batteryCount");
        if (other.tag == "battery")
        {
            if (batteryCount == 6)
            {
                PressE.enabled = false;
                BatteryText.enabled = true;

            }
            else
            {
                PressE.enabled = true;
                BatteryText.enabled = false;
            }

            if (Input.GetKeyDown(KeyCode.E))
            {
                PressE.enabled = false;
                if (batteryCount < 6) { batteryCount++; Destroy(other.gameObject); }
                PlayerPrefs.SetInt("batteryCount", batteryCount);
                for (int i = 0; i < batteryCount; i++)
                {
                    batteries[i].SetActive(true);

                }
            }

        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "battery")
        {
            PressE.enabled = false;
            BatteryText.enabled = false;

        }
    }
    public void batteryUse()
    {
        batteryCount = PlayerPrefs.GetInt("batteryCount");
        batteries[batteryCount - 1].SetActive(false);
        batteryCount--;
        PlayerPrefs.SetInt("batteryCount", batteryCount);
        enerji += 50;
        if (enerji >= 100)
        {
            enerji = 100f;
        }
    }
}
