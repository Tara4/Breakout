﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        ScoreScript.scoreValue += 1;
        Destroy(gameObject);
        FindObjectOfType<BrickSpawnScript>().RemoveBrick(this);
    }
}
