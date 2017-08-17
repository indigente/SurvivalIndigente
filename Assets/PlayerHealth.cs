using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public float health;
	public float dmgAmountTest;
	public Text healthDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		healthDisplay.text = "Health:" + health;


		///if (Input.GetKeyDown (KeyCode.T)) {
		//	health -= dmgAmountTest;
		//}

		if (health <= 0) {
			Destroy (this.gameObject);
		}
	}


	//void OnCollisionStay2D(Collision2D enemy){
	//	if (enemy.gameObject.tag == "Enemy") {
	//		health -= dmgAmountTest;
	//		print ("acertou");
	//	}

		void OnCollisionEnter2D(Collision2D enemy){
			if (enemy.gameObject.tag == "Enemy") {
				health -= dmgAmountTest;
				print ("acertou");
			}
	}
}
