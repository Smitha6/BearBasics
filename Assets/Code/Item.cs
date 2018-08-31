using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 snapSize = new Vector3(1, 1, 1);
    Vector3 startPos;

    // Use this for initialization
    void Start() {
        startPos = this.gameObject.transform.position;
    }

    // Update is called once per frame
    void Update() {

        Vector3 i = this.gameObject.transform.position.Distance;

    }

    // Moves button to position
    private void OnMouseDrag(){
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, 10);
    }

    private void OnMouseUp(){
        //this.gameObject.transform.position = startPos;

        if (Vector3.Distance(this.gameObject.transform.position, Vector3){

        }
        
    }


}