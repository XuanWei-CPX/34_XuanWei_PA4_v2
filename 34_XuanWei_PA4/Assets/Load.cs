﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadScene", 1f);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void LoadScene()
    {
        SceneManager.LoadScene(1);
    }
}
