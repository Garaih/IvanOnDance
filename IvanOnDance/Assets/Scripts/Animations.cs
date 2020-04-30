using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public GameObject[] goNiggas;
    public GameObject goAtaud;
    Animator[] animNiggas = new Animator[2];
    Animator animAtaud;



    void Start()
    {
        for (int i = 0; i < goNiggas.Length; i++)
        {
            animNiggas[i] = goNiggas[i].GetComponent<Animator>();
        }

        animAtaud = goAtaud.GetComponent<Animator>();
    }


    public void AnimAtaud()
    {
        float rnd = Random.Range(0, 2);

        if(rnd < 1)
        {
            animAtaud.SetTrigger("Ataud1");
        }
        else
        {
            animAtaud.SetTrigger("Ataud2");
        }
    }

    public void AnimNegrata(int nigga)
    {
        float rnd = Random.Range(0, 4);

        if (rnd < 1)
        {
            animNiggas[nigga].SetTrigger("Anim1");
        }
        else if (rnd < 2)
        {
            animNiggas[nigga].SetTrigger("Anim2");
        }
        else if (rnd < 3)
        {
            animNiggas[nigga].SetTrigger("Anim3");
        }
        else
        {
            animNiggas[nigga].SetTrigger("Anim4");
        }
    }

    public void Mix()
    {
        animAtaud.SetTrigger("Mix");
        animNiggas[0].SetTrigger("Mix");
        animNiggas[1].SetTrigger("Mix");
        //animNiggas[2].SetTrigger("Mix");
        //animNiggas[3].SetTrigger("Mix");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            AnimAtaud();
        }
        if (Input.GetKeyDown(KeyCode.N))
        {
            AnimNegrata(0);
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            AnimNegrata(1);
        }
        if (Input.GetKeyDown(KeyCode.V))
        {
            Mix();
        }
    }
}
