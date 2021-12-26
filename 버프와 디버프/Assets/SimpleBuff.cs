using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBuff : MonoBehaviour
{
    public bool speed = false;

    void Update()
    {
        float displacement = 1 * Time.deltaTime;
        if (speed)
            displacement *= 2;

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(displacement, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(-displacement, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(0, displacement, 0);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(0, -displacement, 0);
    }
}