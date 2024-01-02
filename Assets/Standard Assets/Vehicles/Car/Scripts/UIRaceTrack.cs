using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UIRaceTrack : MonoBehaviour
{
    public Text WinMessage;
    public Text Credits;
    public GameObject Leaderboard;
    public int FirstPlaceCredits = 2000;
    public int SecondPlaceCredits = 1000;
    public int ThirdPlaceCredits = 500;
    // Start is called before the first frame update
    void Start()
    {
        Leaderboard.SetActive(false);
        if (UniversalSave.OpponentsCount > 0)
        {
            FirstPlaceCredits *= UniversalSave.OpponentsCount;
            SecondPlaceCredits *= UniversalSave.OpponentsCount;
            ThirdPlaceCredits *= UniversalSave.OpponentsCount;
        }
        if (FinishLine.PlayerFinishPosition == 1)
        {
            WinMessage.text = "1ST PLACE";
            Credits.text = FirstPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += FirstPlaceCredits;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition == 2)
        {
            WinMessage.text = "2ND PLACE";
            Credits.text = SecondPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += SecondPlaceCredits;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition == 3)
        {
            WinMessage.text = "3RD PLACE";
            Credits.text = ThirdPlaceCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += ThirdPlaceCredits;
            UniversalSave.RacesWon++;
        }
        if (FinishLine.PlayerFinishPosition > 3)
        {
            WinMessage.text = FinishLine.PlayerFinishPosition + "TH PLACE";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }
        UniversalSave.Saving = true;
    }
    public void DisplayLeaderboard()
    {
        Leaderboard.SetActive(true);
        this.gameObject.SetActive(false);
        Time.timeScale = 0;
    }
}
        