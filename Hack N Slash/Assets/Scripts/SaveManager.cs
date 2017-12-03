using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour {
    public static SaveManager Instance;
	// Use this for initialization
    void Awake()
    {
        if (Instance)
            Destroy(this.gameObject);
    }
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
