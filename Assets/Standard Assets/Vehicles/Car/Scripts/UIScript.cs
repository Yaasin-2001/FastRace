using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    public Image SpeedRing;
    private float DisplaySpeed;
    public Text SpeedText;
    public Text GetText;
    public Text LapNumberText;
    public Text TotalLapsText;
    public int TotalLaps = 3;
    public Text LapTimeMinutesText;
    public Text LapTimeSecondsText;

    // Start is called before the first frame update
    void Start()
    {
        SpeedRing.fillAmount = 0;
        SpeedText.text = "0";
        GetText.text = "1";
        LapNumberText.text = "0";
        TotalLapsText.text = "/" + TotalLaps.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        // Speedometer
        DisplaySpeed = SaveScript.Speed / SaveScript.TopSpeed;
        SpeedRing.fillAmount = DisplaySpeed;
        SpeedText.text = (Mathf.Round(SaveScript.Speed).ToString());
        GetText.text = (SaveScript.Gear + 1).ToString();

        //LapNumber
        LapNumberText.text = SaveScript.LapNumber.ToString();


        //LapTime
        if (SaveScript.LapTimeMinutes <= 9)
        {
            LapTimeMinutesText.text = "0" + (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }
        else if (SaveScript.LapTimeMinutes >= 10)
        {
            LapTimeMinutesText.text = (Mathf.Round(SaveScript.LapTimeMinutes).ToString()) + ":";
        }

        if (SaveScript.LapTimeSeconds <= 9)
        {
            LapTimeSecondsText.text = "0" + (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }

        else if (SaveScript.LapTimeSeconds >= 10)
        {
            LapTimeSecondsText.text = (Mathf.Round(SaveScript.LapTimeSeconds).ToString());
        }
        

    }
}
