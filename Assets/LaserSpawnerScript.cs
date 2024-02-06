using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawnerScript : MonoBehaviour
{
    public GameObject laser;
    public GameObject superLaser;
    public BirdScript bird;
    public float timePressed = 0;
    public AudioSource laserSound;
    public AudioSource superLaserSound;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z) && bird.birdIsAlive)
        {
            fireLaser();
        }
        if (xKeyPressedTimer() > 1.5 && bird.birdIsAlive)
        {
            
            fireSuperLaser();
            timePressed = 0;
        }
        
    }
    void fireLaser()
    {
        float birdPositionX = bird.getPositionX();
        float birdPositionY = bird.getPositionY();
        Instantiate(laser, new Vector3(birdPositionX, birdPositionY, 0), transform.rotation);
        laserSound.Play();
    }

    void fireSuperLaser()
    {
        float birdPositionX = bird.getPositionX();
        float birdPositionY = bird.getPositionY();
        Instantiate(superLaser, new Vector3(birdPositionX, birdPositionY, 0), transform.rotation);
        superLaserSound.Play();
    }

    float xKeyPressedTimer()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            timePressed = Time.time;
        }

        if (Input.GetKeyUp(KeyCode.X))
        {
            timePressed = Time.time - timePressed;
        }
        return timePressed;
    }
    
}
 