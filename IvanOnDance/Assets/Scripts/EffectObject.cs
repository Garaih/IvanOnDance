using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectObject : MonoBehaviour
{
    public float lifeTime;

    void Start()
    {
        
    }
    
    void Update()
    {
        Destroy(gameObject, lifeTime);
    }
}
