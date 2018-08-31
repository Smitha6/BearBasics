using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Vector3 mousePosition;
    int snapSize = 1;
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

    
    private void OnMouseUp(){

        //get closest cell
        GameObject cell = FindClosestCell();
        Cell script = cell.GetComponent<Cell>();
        


        //get its center
        Vector3 center = cell.transform.position;
        

        //move this to cells center if its close enough
        if (Vector3.Distance(center, this.gameObject.transform.position) <= snapSize && script.HasItem() == false){
            this.transform.position = center;
            script.HasItem(true);
        }
        else{
            MoveToStart();
            script.HasItem(false);
        }
        
    }

    // Finds the closest cell
    public GameObject FindClosestCell()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Cell");
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
    private void MoveToStart() { 
        float speed = .1f;
        while (this.gameObject.transform.position != startPos) {
            // Move our position a step closer to the target.
            this.gameObject.transform.position = Vector3.MoveTowards(transform.position, startPos, speed * Time.deltaTime);
        }
    }
    


}