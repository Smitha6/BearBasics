using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject player;
    private int speed = 5;

    public bool moveRight = false;
    public bool moveLeft = false;
    public bool moveUp = false;
    public bool moveDown = false;

    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        if (moveRight == false) {
            player.transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        if (moveLeft == true) {
            player.transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (moveUp == true) {
            player.transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        if (moveDown == true) {
            player.transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        

    }
    
}
