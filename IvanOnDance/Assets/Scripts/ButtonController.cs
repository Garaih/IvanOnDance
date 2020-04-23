using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
    SpriteRenderer sprite;
    public Sprite[] images;

    public KeyCode buttonKey;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        sprite.sprite = images[0];
    }
    
    void Update()
    {
        if (Input.GetKeyDown(buttonKey))
        {
            sprite.sprite = images[1];
        }

        if (Input.GetKeyUp(buttonKey))
        {
            sprite.sprite = images[0];
        }
    }
}
