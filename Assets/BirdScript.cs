using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    public AudioSource collisionSound;
    public AudioSource flapSound;
    public Vector3 birdPosition;
    public float birdDeathZoneUpper;
    public float birdDeathZoneLower;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive && birdIsInScene())
        {
            flapSound.Play();
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        if (myRigidbody.transform.position.y < birdDeathZoneLower)
        {
            birdIsAlive = false;
            logic.gameOver();
        }
        if (Input.GetKeyDown(KeyCode.Z) && birdIsAlive)
        {
            
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe")) 
        {
            collisionSound.Play();
            logic.gameOver();
            birdIsAlive = false;
        }
        
    }

    public float getPositionX()
    {
        return myRigidbody.transform.position.x;
        
    }

    public float getPositionY()
    {
        return myRigidbody.transform.position.y;
        
    }
    
    public bool birdIsInScene()
    {
        return myRigidbody.transform.position.y > birdDeathZoneLower && myRigidbody.transform.position.y < birdDeathZoneUpper;
    }


}
