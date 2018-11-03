using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerP : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            //doesn't pick up anything yet
            Destroy(gameObject);
        }
    }
}
