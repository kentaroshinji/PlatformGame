using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public Transform mSpawnPoint;

    public float mFallLimit;

    // Use this for initialization
    void Start ()
    {
        mSpawnPoint.position = new Vector3(transform.position.x, transform.position.y, 0.0f);
    }
	
	// Update is called once per frame
	void Update ()
    {
		if(transform.position.y < mFallLimit)
        {
            transform.position = new Vector3(mSpawnPoint.position.x, mSpawnPoint.position.y, 0.0f);
        }
	}
}
