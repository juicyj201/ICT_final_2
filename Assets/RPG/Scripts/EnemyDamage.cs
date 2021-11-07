using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyDamage : MonoBehaviour
{
    public GameObject player;
    public GameObject evilKing;
    public Canvas enemyHealthBar;
    public Image enemyhealth1;
    public Image enemyhealth2;
    public Image enemyhealth3;
    public Image enemyhealth4;
    public Image enemyhealth5;
    public Image enemyhealth6;

    private float counter;
	private float start = 0f;
	private float end = 2f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire3")) {
            counter += 1;
        }
    }

    private void Counter() {
        if (counter == 2) {
            enemyhealth2.enabled = false;
        }
        else if (counter == 4)
        {
            enemyhealth3.enabled = false;
        }
        else if (counter == 6)
        {
            enemyhealth4.enabled = false;
        }
        else if (counter == 8)
        {
            enemyhealth5.enabled = false;
        }
        else if (counter == 10)
        {
            enemyhealth6.enabled = false;
        }
		else if(counter > 10){
			Destroy(evilKing);
		}

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetButton("Fire3")) {
            enemyhealth1.enabled = false;

            //counter += 1;

            //Counter();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && Input.GetButtonDown("Fire3"))
        {
			//counter += 1;

            Counter();
        }
    }
}
