using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public GameObject[] goNiggas;
    public GameObject goAtaud;
    Animator[] animNiggas = new Animator[4];
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
        animNiggas[2].SetTrigger("Mix");
        animNiggas[3].SetTrigger("Mix");
    }
    public void Death()
    {
        animAtaud.SetTrigger("Death");
        animNiggas[0].SetTrigger("Death");
        animNiggas[1].SetTrigger("Death");
        animNiggas[2].SetTrigger("Death");
        animNiggas[3].SetTrigger("Death");
    }

    private void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            AnimAtaud();
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            AnimNegrata(0);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            AnimNegrata(1);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            AnimNegrata(2);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            AnimNegrata(3);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Mix();
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            Death();
        }
        
    }
}
