using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    Buffable buffable;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            buffable.AddBuff(new TestBuff());

        float displacement = buffable.Speed * Time.deltaTime;
        
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
