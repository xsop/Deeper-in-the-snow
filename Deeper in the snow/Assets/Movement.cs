using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;
	void Start () {
        speed = 10;
	}
	
	// Update is called once per frame
	void Update () {
        Move(); 
	}
    void Move()
    {
        if (Input.GetKey("w"))
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        if (Input.GetKey("s"))
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        if (Input.GetKey("d"))
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        if (Input.GetKey("a"))
            transform.Translate(Vector2.left * speed * Time.deltaTime);

    }
}
