using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;



public class balltouch : MonoBehaviour
{
    public Transform ball2;
    public TextMeshProUGUI powerText, gameOverText;
    public int power;
    public AudioSource missedBall;


    void Update()
    {
        powerText.text = "POWER: " + power;

        if (power == 0)
        {
            gameOverText.text = "GAME OVER! \n TRY AGAIN \n press any key";
            Time.timeScale = 0;

            if(Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;

            }
        }
    } 

    void OnCollisionEnter(Collision contact)
    {

        float yrandom = Random.Range(-11f, 11f);
        if (contact.gameObject.tag == "floor")
        {
            ball2.position = new Vector3(yrandom, 6, 0f);
            power--;
            missedBall.Play();
        }
    }
}
