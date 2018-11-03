using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour {

    public GameObject TriggerZone;
    public TriggerFall a;
    
    void Start()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "environment")
        {
            a = TriggerZone.GetComponent<TriggerFall>();
            a.fall = 2;
            Destroy(gameObject);
                
        }
    }
}


