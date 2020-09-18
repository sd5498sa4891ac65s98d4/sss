using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float animalSpeed = 2;
        Vector3 position = this.transform.position;
        position.x = position.x + animalSpeed;
        this.transform.position = position;
    }
}
