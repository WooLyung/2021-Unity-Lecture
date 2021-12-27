using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchieveManager
{
    int Clicked
    {
        get => PlayerPrefs.GetInt("click", 0);
        set => PlayerPrefs.SetInt("click", value);
    }

    static AchieveManager _instance;

    public static AchieveManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = new AchieveManager();
            return _instance;
        }
        set => _instance = value;
    }

    public void AddClick()
    {
        Clicked++;
        Debug.Log(Clicked.ToString());

        if (PlayerPrefs.GetInt("achieve", 0) == 0 && Clicked >= 100)
        {
            Debug.Log("업적 달성");
            PlayerPrefs.SetInt("achieve", 1);
        }
    }
}
