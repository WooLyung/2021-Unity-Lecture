using UnityEngine;

public class ClickAchieve : Observer
{
    int Clicked
    {
        get => PlayerPrefs.GetInt("click", 0);
        set => PlayerPrefs.SetInt("click", value);
    }

    public void Notify(Subject subject, Event e)
    {
        if (e.Name == "ClickEvent")
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
}