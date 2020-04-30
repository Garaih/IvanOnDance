using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float hitHeight = -4f;

    public KeyCode buttonKey;

    bool canBePressed;
    bool hasBeenPressed;

    void Start()
    {
        canBePressed = false;
        hasBeenPressed = false;
    }
    
    void Update()
    {
        if (Input.GetKeyDown(buttonKey))
        {
            if (canBePressed)
            {
                hasBeenPressed = true;

                gameObject.SetActive(false);

                float distance = Mathf.Abs(transform.position.y - hitHeight);

                GameManager.Instance.NoteHit(distance, transform.position);
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
            if (!hasBeenPressed)
            {
                canBePressed = false;

                GameManager.Instance.NoteMiss(transform.position);
            }
        }
    }
}
