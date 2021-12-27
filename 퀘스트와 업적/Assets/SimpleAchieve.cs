using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAchieve : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            AchieveManager.Instance.AddClick();
    }
}
