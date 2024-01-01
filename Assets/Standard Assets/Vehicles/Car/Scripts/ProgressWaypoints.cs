using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressWaypoints : MonoBehaviour
{
    public int WPNumber;
    public int CarTracking = 0;
    public bool PenaltyOption = false;
    public int PenaltyWayPoint;
    public int Position = 0;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Progress"))
        {
            CarTracking = other.GetComponent<ProgressTracker>().CurrentWP;
            if (CarTracking < WPNumber)
            {
                other.GetComponent<ProgressTracker>().CurrentWP = WPNumber;
                // Debug.Log("CurrentWP =" + other.GetComponent<ProgressTracker>().CurrentWP);
                Position++;
                SaveScript.PlayerPosition = Position;
            }
            if (CarTracking > WPNumber)
            {
                other.GetComponent<ProgressTracker>().LastWPNumber = WPNumber;
            }
            if (PenaltyOption == true)
            {
                if (CarTracking < PenaltyWayPoint)
                {
                    Debug.Log("Penalty");
                    SaveScript.PenaltySeconds += 5f;
                    PenaltyOption = false;
                }
            }
        }
        }
}
