using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockPlace : MonoBehaviour {

    public GameObject grid; // grid where blocks are placed
    public List<GameObject> blockTypes; // list of the types of available blocks to use
    public List<GameObject> placedBlocks; // list of created blocks
    public GameObject cursor; // the cursor where blocks can be placed
    public int whichBlock; // which block type is selected

	// Use this for initialization
	void Start ()
    {
        whichBlock = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        // If left mouse button clicked
        if (Input.GetMouseButtonDown(0))
        {
            // create a new block of the type currently selected at the cursors position
            GameObject newBlock = Instantiate(blockTypes[whichBlock], grid.transform);
            newBlock.transform.position = new Vector3(cursor.transform.position.x+.5f, cursor.transform.position.y+2, 0.0f);
            placedBlocks.Add(newBlock);
        }
    }
}
