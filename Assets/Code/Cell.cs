using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {
    Transform itemT;
    GameObject item;

	// Use this for initialization
	void Start () {
        //gets child item
        if (this.gameObject.transform.childCount > 0){
            itemT = gameObject.transform.GetChild(0);
            item = itemT.gameObject;
        }
        

    }
	
	// Update is called once per frame
	void Update () {
        

		
	}






}
