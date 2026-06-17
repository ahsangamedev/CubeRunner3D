using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerScript playerScript;
    public Score score; // the script
    public GameController gameController;
    
    public AudioSource audioSource; 
    public AudioSource audioSource1; 


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectable")
        {
            audioSource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
            
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Obstacles")
        {
            audioSource1.Play();
            playerScript.enabled = false;
            gameController.GameOver();

        }
    }




}
