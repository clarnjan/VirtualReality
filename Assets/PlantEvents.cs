﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlantEvents : MonoBehaviour
{
    float entered = -1F;
    bool has_entered = false;
    public void enter()
    {
        has_entered = true;
        entered = Time.time;
        Debug.Log("Entered");
    }

    public void exit()
    {
        has_entered = false;
        Debug.Log("Exited");
    }

    // Update is called once per frame
    void Update()
    {
        if (has_entered && Time.time - entered > 1.5)
        {
            Debug.Log(entered);
            Debug.Log(Time.time);
            transform.Rotate(Vector3.up * 60 * Time.deltaTime);
        }
    }
}
