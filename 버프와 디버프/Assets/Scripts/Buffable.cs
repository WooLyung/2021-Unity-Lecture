using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buffable : MonoBehaviour
{
    List<Buff> buffs = new List<Buff>();

    public void AddBuff(Buff buff) => buffs.Add(buff);

    public float Speed
    {
        get
        {
            float speed = 1.0f;
            foreach (Buff buff in buffs)
                if (buff is SpeedBuff)
                    speed *= (buff as SpeedBuff).Speed;

            return speed;
        }
    }
}