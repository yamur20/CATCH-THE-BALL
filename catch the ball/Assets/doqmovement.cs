using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class doqmovement : MonoBehaviour
{
    public float speed;
    public Transform ball;
    private int score;
    public TextMeshProUGUI scoreText;
    public AudioSource catchBall;




    void Update()
    {
        scoreText.text = "Score: " + score;

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-speed*Time.deltaTime,0f,0f);
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(speed*Time.deltaTime,0f,0f);
        }
    }
    void OnCollisionEnter(Collision contact)
    {
        float yrandom = Random.Range(-11f, 11f);

        if(contact.gameObject.tag == "ball")
        {
            ball.position = new Vector3(yrandom,6,0f);
            score += 5;
            catchBall.Play ();


        }


    }
}
