﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Resalt : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Goal")
        {
            SceneManager.LoadScene("Resalt");
        }
    }
}
