using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public Transform mSpawnPoint;

    public Transform mCamera;

    public float mFallLimit;

    public BlockPlace blockPlace;

    // Use this for initialization
    void Start()
    {
        mSpawnPoint.position = new Vector3(transform.position.x, transform.position.y, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < mFallLimit || Input.GetKeyDown("r")) // respawn if fallen too far or the r key is pressed
        {

            transform.position = new Vector3(mSpawnPoint.position.x, mSpawnPoint.position.y, 0.0f);
            mCamera.position = new Vector3(0.0f, 0.0f, mCamera.position.z);
            while(blockPlace.placedBlocks.Count > 0)
            {
                Destroy(blockPlace.placedBlocks[0]);
                blockPlace.placedBlocks.RemoveAt(0);
            }
        }
	}
}
