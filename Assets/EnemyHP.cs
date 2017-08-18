using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {
    public int HP;
    public int armor;


	// Use this for initialization
	void Start () {
        armor = 0;
	}

    private void OnTriggerEnter2D(Collider2D collision) {
        if (collision.gameObject.GetComponent<StatsArma>() != null){
            HP -= recebeDano(collision.gameObject.GetComponent<StatsArma>()) - armor;
            if (HP <= 0){
                Destroy(this.gameObject);
            }
            print(HP);
        } else
        {
            print("Not peixeira");
        }

    }

    public int recebeDano (StatsArma myArma) {
 
        return myArma.dano;
    }
    

    // Update is called once per frame
    void Update () {
        
		
	}
}
