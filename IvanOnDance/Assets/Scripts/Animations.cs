using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public GameObject[] goNiggas;
    Animator[] animNiggas;


    void Start()
    {
        for (int i = 0; i < goNiggas.Length; i++)
        {
            animNiggas[i] = goNiggas[i].GetComponent<Animator>();
        }
    }

    public void Anim1 (int nigga)
    {
        animNiggas[nigga].SetTrigger("Anim1");
    }
    public void Anim2 (int nigga)
    {
        animNiggas[nigga].SetTrigger("Anim2");
    }
    public void Anim3 (int nigga)
    {
        animNiggas[nigga].SetTrigger("Anim3");
    }
}
