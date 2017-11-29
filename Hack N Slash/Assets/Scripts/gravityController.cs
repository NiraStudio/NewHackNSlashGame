using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravityController: MonoBehaviour {
    public float fallMultiPlay=2;
    Rigidbody2D rg;
	// Use this for initialization
	void Start () {
        rg = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (rg.velocity.y < 0)
        {
            rg.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiPlay - 1) * Time.deltaTime;
        }
	}
}
