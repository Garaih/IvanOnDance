using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public KeyCode buttonKey;

    bool canBePressed;

    void Start()
    {
        canBePressed = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(buttonKey))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);

                GameManager.Instance.NoteHit();
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;

            GameManager.Instance.NoteMiss();
        }
    }
}
