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
        
    }

public void OptionsOff()
{
    TrackOptions.SetActive(false);
}

}