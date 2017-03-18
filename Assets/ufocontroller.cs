using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufocontroller : MonoBehaviour {

    //private Transform myTransform;
    public float forceValue = 10;
    private Rigidbody2D rigidbody2D = null;
    public ScoreManager scoremanager;
    // Use this for initialization
    void Start () {
        //myTransform = this.GetComponent< Transform > ();
        rigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    public float speed ;
	// Update is called once per frame
	void Update () {
        

        Vector2 force2D = Vector2.zero;

        if (Input.GetKey(KeyCode.W))
        {
            force2D.y += forceValue;
        }
        if (Input.GetKey(KeyCode.S))
        {
            force2D.y -= forceValue;
        }
        if (Input.GetKey(KeyCode.A))
        {
            force2D.x -= forceValue;
        }
        if (Input.GetKey(KeyCode.D))
        {
            force2D.x += forceValue;
        }

        rigidbody2D.AddForce(force2D);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        other.gameObject.SetActive(false); //把金幣關掉
        scoremanager.AddScore(100);
    }
}
