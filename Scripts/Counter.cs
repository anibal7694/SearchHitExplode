/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour {
	public GameObject explode;
	private int count = 0;
	private int objcount; 
	public Text objectcounter; 
	public Text counter;
	public int fireballcounter = 20 ; 
	private bool isActive;
	public GameObject activate; 
	void Start () {
		objcount = GameObject.FindGameObjectsWithTag("target").Length;
		objectcounter.text = "Objects left: " + objcount.ToString();
		counter.text = "Score : " + count.ToString();
		explode.SetActive(false);
	}
	void Update()
	{
		isActive= activate.GetComponent<CollisionDestroy>().activate;
		if(isActive)
		{
			counting();
		}
	}
	
	void OnCollisionEnter(Collision other)
	{
		
	}
	public void counting()
	{
		objcount -= 1; 
		count += 1;
		fireballcounter -= 1;
		counter.text = "Score: " + count.ToString();
		objectcounter.text = "Objects left: " + objcount.ToString();
		//counter.text = "Score : " + count.ToString();
		if(fireballcounter <= 0)
		{
			//lock.ke
		}
	}
}*/
