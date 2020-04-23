using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour
{
    public float tempo;

    bool start;


    void Start()
    {
        start = false;
        tempo /= 60;
    }
    
    void Update()
    {
        if (!start)
        {
            if (Input.anyKeyDown)
            {
                start = true;
            }
        }

        else
        {
            transform.position -= new Vector3(0, tempo * Time.deltaTime, 0);
        }
    }
}
