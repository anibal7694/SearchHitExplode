using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDestroy : MonoBehaviour {

	public GameObject explode;
	private int count;
	private int objcount; 
	private int totalobjcount = 12;
	public Text objectcounter; 
	public Text counter;
	public int fireballcounter = 20 ; 
	//public Text GameOverText;
	//public bool activate;

	// Use this for initialization
	void Start () {
		explode.SetActive(false);
		objcount = GameObject.FindGameObjectsWithTag("target").Length;
		objectcounter.text = "Objects left: " + objcount.ToString();
		//GameOverText.enabled = false;
		count = totalobjcount - objcount;
		counter.text = "Score : " + count.ToString();
		//explode.SetActive(false);
		//activate = false;

	}

	// Update is called once per frame
	void Update ()
	{
		/*if (Input.GetKeyDown("v"))
		{
			explode.SetActive(true);
			GameObject explosion = Instantiate(explode, transform.position, Quaternion.identity) as GameObject;
			Destroy(this.gameObject);
			Destroy(explosion, 2);
		}*/
	}
	void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.CompareTag("target"))
		{
			explode.SetActive(true);
			GameObject explosion = Instantiate(explode, transform.position, Quaternion.identity) as GameObject;
			Destroy(this.gameObject);
			Destroy(explosion, 2);
			counting();
			//activate = true; 
			/*bool activate = true;
			GetComponent<Counter>().isActive = activate; */
			other.gameObject.SetActive(false);
		}
	}
	void counting()
	{
		objcount -= 1; 
		count = totalobjcount - objcount;
		fireballcounter -= 1;
		counter.text = "Score: " + count.ToString();
		objectcounter.text = "Objects left: " + objcount.ToString();
		//counter.text = "Score : " + count.ToString();
		/*if(fireballcounter <= 0)
		{
			GameOverText.enabled = true;
			GameOverText.text = "YOU HAVE RUN OUT OF FIREBALLS" ;
		}*/
		if(objcount == 0)
			Application.LoadLevel(Application.loadedLevel +1);
	}

}
