using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalSave : MonoBehaviour
{
    public static int LapCounts;
    public static int OpponentsCount;
    public static int CreditAmount;
    public static bool Saving = false;
    public static bool Calculation = false;
    public static string PlayerName = "PLAYER";
    public static int RacesWon = 0;
    public static int RacesLost = 0;
    public static bool SportsCar1Owned = false;
    public static bool SportsCar2Owned = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        LoadStats();
    }
    private void Update()
    {
        if (Saving == true)
        {
            Saving = false;
            SaveStats();
        }
    }
    public void SaveStats()
    {
        PlayerPrefs.SetInt("MyCredits", CreditAmount);
        PlayerPrefs.SetString("PlayName", PlayerName);
        PlayerPrefs.SetInt("WonRaces", RacesWon);
        PlayerPrefs.SetInt("LostRaces", RacesLost);
        PlayerPrefs.SetInt("MyCar", SaveScript.SportsCarID);
        if (SportsCar1Owned == false)
        {
            PlayerPrefs.SetInt("Car1", 0);
        }
        if (SportsCar1Owned == true)
        {
            PlayerPrefs.SetInt("Car1", 1);
        }
        if (SportsCar2Owned == false)
        {
            PlayerPrefs.SetInt("Car2", 0);
        }
        if (SportsCar2Owned == true)
        {
            PlayerPrefs.SetInt("Car2", 1);
        }
    }
    public void LoadStats()
    {
        CreditAmount = PlayerPrefs.GetInt("MyCredits");
        PlayerName = PlayerPrefs.GetString("PlayName");
        RacesWon = PlayerPrefs.GetInt("WonRaces");
        RacesLost = PlayerPrefs.GetInt("LostRaces");
        SaveScript.SportsCarID = PlayerPrefs.GetInt("MyCar");
        if (PlayerPrefs.GetInt("Car1") == 1)
        {
            SportsCar1Owned = true;
        }
        if (PlayerPrefs.GetInt("Car2") == 1)
        {
            SportsCar2Owned = true;
        }
    }
}
