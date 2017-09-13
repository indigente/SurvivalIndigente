using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public GameObject theSword;
	public float timer, timerAux, cd, cdAux;
	public bool isAttacking;
    public PlayerMovement myScriptMove;

	// Use this for initialization
	void Start () {
		timer = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (timer == 0) {
			theSword.SetActive (false);
		}

		if(Input.GetKeyDown(KeyCode.K) && cd == 0)
        {
			isAttacking = true;
			theSword.SetActive (true);
           // print(myScriptMove.playerDirection);
           // theSword.transform.localPosition = myScriptMove.playerDirection;
		}

		if (isAttacking) {
			timer += Time.deltaTime;
			if (timer >= timerAux) {
				timer = 0;
				isAttacking = false;
				cd = cdAux;
			}
		}
		cd -= Time.deltaTime;
		if (cd <= 0) {
			cd = 0;
		}
	}

}
