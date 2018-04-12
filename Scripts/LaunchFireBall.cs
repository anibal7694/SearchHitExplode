using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaunchFireBall : MonoBehaviour {

	public GameObject fireball;
	float fireRate = 0.5f;
	int shootForce = 10;
	private Rigidbody rb;
	public GameObject FPS;

	// Use this for initialization
	void Start () {
		fireball.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			GameObject clonefireball = Instantiate(fireball, fireball.transform.position, FPS.transform.rotation);
			clonefireball.SetActive(true);
			rb = clonefireball.GetComponent<Rigidbody>();
			rb.AddForce(FPS.transform.forward * shootForce);
			Destroy(clonefireball, 3);
		}
	}

}
