using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UITimeTrial : MonoBehaviour
{
    public Text TimeTrialMinutesG;
    public Text TimeTrialMinutesS;
    public Text TimeTrialMinutesB;
    public Text TimeTrialSecondsG;
    public Text TimeTrialSecondsS;
    public Text TimeTrialSecondsB;
    public Text WinMessage;
    public Text Credits;
    public GameObject TimeTrialObject;
    public GameObject TimeTrialResults;
    public GameObject GoldStar;
    public GameObject SilverStar;
    public GameObject BronzeStar;
    public GameObject QuitPanel;
    private bool Winner = false;
    public int GoldCredits = 3000;
    public int SilverCredits = 1500;
    public int BronzeCredits = 700;
    // Start is called before the first frame update
    void Start()
    {
        TimeTrialObject.SetActive(true);
        TimeTrialResults.SetActive(false);
        QuitPanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        //Setting the timetrial Gold time
        if (SaveScript.TimeTrialMinG <= 9)
        {
            TimeTrialMinutesG.text = "0" + SaveScript.TimeTrialMinG.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinG >= 10)
        {
            TimeTrialMinutesG.text = SaveScript.TimeTrialMinG.ToString() + ":";
        }
        if (SaveScript.TimeTrialSecondsG <= 9)
        {
            TimeTrialSecondsG.text = "0" + SaveScript.TimeTrialSecondsG.ToString();
        }
        if (SaveScript.TimeTrialSecondsG >= 10)
        {
            TimeTrialSecondsG.text = SaveScript.TimeTrialSecondsG.ToString();
        }
        //Setting the timetrial Silver time
        if (SaveScript.TimeTrialMinS <= 9)
        {
            TimeTrialMinutesS.text = "0" + SaveScript.TimeTrialMinS.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinS >= 10)
        {
            TimeTrialMinutesS.text = SaveScript.TimeTrialMinS.ToString() + ":";
        }
        if (SaveScript.TimeTrialSecondsS <= 9)
        {
            TimeTrialSecondsS.text = "0" + SaveScript.TimeTrialSecondsS.ToString();
        }
        if (SaveScript.TimeTrialSecondsS >= 10)
        {
            TimeTrialSecondsS.text = SaveScript.TimeTrialSecondsS.ToString();
        }
        //Setting the timetrial Bronze time
        if (SaveScript.TimeTrialMinB <= 9)
        {
            TimeTrialMinutesB.text = "0" + SaveScript.TimeTrialMinB.ToString() + ":";
        }
        if (SaveScript.TimeTrialMinB >= 10)
        {
            TimeTrialMinutesB.text = SaveScript.TimeTrialMinB.ToString() + ":";
        }
        if (SaveScript.TimeTrialSecondsB <= 9)
        {
            TimeTrialSecondsB.text = "0" + SaveScript.TimeTrialSecondsB.ToString();
        }
        if (SaveScript.TimeTrialSecondsB >= 10)
        {
            TimeTrialSecondsB.text = SaveScript.TimeTrialSecondsB.ToString();
        }
        if (SaveScript.RaceOver == true)
        {
            if (Winner == false)
            {
                Winner = true;
                StartCoroutine(WinDisplay());
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitPanel.SetActive(true);
        }
    }
    IEnumerator WinDisplay()
    {
        yield return new WaitForSeconds(0.15f);
        TimeTrialResults.SetActive(true);
        if (SaveScript.Gold == true)
        {
            WinMessage.text = "GOLD";
            GoldStar.SetActive(true);
            Credits.text = GoldCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += GoldCredits;
            UniversalSave.RacesWon++;
        }
        if (SaveScript.Silver == true)
        {
            WinMessage.text = "SILVER";
            SilverStar.SetActive(true);
            Credits.text = SilverCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += SilverCredits;
            UniversalSave.RacesWon++;
        }
        if (SaveScript.Bronze == true)
        {
            WinMessage.text = "BRONZE";
            BronzeStar.SetActive(true);
            Credits.text = BronzeCredits.ToString();
            UniversalSave.CreditAmount = UniversalSave.CreditAmount += BronzeCredits;
            UniversalSave.RacesWon++;
        }
        if (SaveScript.Fail == true)
        {
            WinMessage.text = "TRY AGAIN";
            Credits.text = "0";
            UniversalSave.RacesLost++;
        }
        UniversalSave.Saving = true;
    }
     public void ReturnToMenu()
     {
         SceneManager.LoadScene(1);
     }
     public void QuitClose()
     {
         QuitPanel.SetActive(false);
     }
}
   
