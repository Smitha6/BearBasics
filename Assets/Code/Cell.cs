using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cell : MonoBehaviour {
    private Transform itemT;
    private GameObject item;
    private bool hasItem;

	// Use this for initialization
	void Start () {
        //gets child item
        if (this.gameObject.transform.childCount > 0) {
            itemT = gameObject.transform.GetChild(0);
            item = itemT.gameObject;
            hasItem = true;
        }
        else
            hasItem = false;
        

    }
	
	// Update is called once per frame
	void Update () {
        


    }

    public bool HasItem() {
        return hasItem;
    }
    public void HasItem(bool h) {
        hasItem = h;
    }






}
