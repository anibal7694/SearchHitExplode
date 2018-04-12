using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomlyFall : MonoBehaviour {


    float x;
    float y;
    float z;
    private Rigidbody rb;
    private Rect textArea;
    Vector3 pos;

    // Use this for initialization
    void Start () {
        x = Random.Range(2, 498);
        y = 0;
        z = Random.Range(2, 498);
        pos = new Vector3(x, y, z);
        transform.position = pos;
        rb = GetComponent<Rigidbody>();
        //textArea = new Rect(10, 10, Screen.width, Screen.height);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
