using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class RaceTrackMenu : MonoBehaviour
{
    public GameObject TrackOptions;
   // public bool F1Race = false;
   // public Text WrongCar;
    public void OptionsOn()
    {
        TrackOptions.SetActive(true);
        /*if (F1Race == true)
        {
            if (SaveScript.SportsCarID == 1)
            {
                TrackOptions.SetActive(true);
                WrongCar.text = " ";
            }
            if (SaveScript.SportsCarID > 1)
            {
                WrongCar.text = "YOU NEED TO BE USING AN F1 CAR";
                StartCoroutine(ResetText());
            }
        }
        if (F1Race == false)
        {
            if (SaveScript.SportsCarID > 1)
            {
                TrackOptions.SetActive(true);
                WrongCar.text = " ";
            }
            if (SaveScript.SportsCarID == 1)
            {

            }
            WrongCar.text = "YOU NEED TO BE USING A SPORTS CAR";
            StartCoroutine(ResetText());
        }*/
    }

public void OptionsOff()
{
    TrackOptions.SetActive(false);
}
/*IEnumerator ResetText()
{
    yield return new WaitForSeconds(3);
    WrongCar.text = " ";
}*/
}