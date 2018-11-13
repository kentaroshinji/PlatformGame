﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerP : MonoBehaviour {
    public string sceneName;
    public int level = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player") && level == 1)
        {
            level = 2;
            SceneManager.LoadScene(sceneName);
            Destroy(gameObject);
        }
    }
}