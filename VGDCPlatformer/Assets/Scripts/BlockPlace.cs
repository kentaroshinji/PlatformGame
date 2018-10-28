using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlace : MonoBehaviour {

    public GameObject grid;
    public List<GameObject> blockTypes;
    public List<GameObject> placedBlocks;
    public GameObject cursor;
    private int whichBlock;

	// Use this for initialization
	void Start ()
    {
        whichBlock = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject newBlock = Instantiate(blockTypes[whichBlock], grid.transform);
            newBlock.transform.position = new Vector3(cursor.transform.position.x+.5f, cursor.transform.position.y+2, 0.0f);
            placedBlocks.Add(newBlock);
        }
    }
}
