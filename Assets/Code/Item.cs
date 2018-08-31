using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Vector3 mousePosition;
    int snapSize = 5;
    Vector3 startPos;

    // Use this for initialization
    void Start() {
        startPos = this.gameObject.transform.position;
        Debug.Log("START");
    }

    // Update is called once per frame
    void Update() {



    }

    // Moves button to position
    private void OnMouseDrag(){
        Debug.Log("IN");
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, 10);
    }

    /*
    private void OnMouseUp(){

        //get closest cell
        GameObject cell = FindClosestCell();


        //get its center
        Vector3 center = cell.transform.position;

        //move this to cells center if its close enough
        if (Vector3.Distance(center, this.gameObject.transform.position) <= snapSize){
            this.transform.position = center;
        }
        else{
            this.gameObject.transform.position = startPos;
        }
        
    }

    // Finds the closest cell
    public GameObject FindClosestCell()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("cell");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }
    */


}