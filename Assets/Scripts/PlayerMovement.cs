using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public AudioSource collectibleSound;
    
    public float speed; //Velocidade do player

    private Rigidbody2D rigid; //Componente Rigidbody2D do player

	void Start () {

        rigid = gameObject.GetComponent<Rigidbody2D>();
		collectibleSound = GetComponent<AudioSource> ();

	}
	
	void Update () {

        rigid.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, Input.GetAxisRaw("Vertical") * speed);
		
	}

	void OnTriggerEnter2D(Collider2D coletavel) 
	{
		
		if (coletavel.gameObject.CompareTag("Coletavel"))
		{
			Destroy (coletavel.gameObject);
			collectibleSound.Play ();
		}
}
}