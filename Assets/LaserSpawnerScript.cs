using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawnerScript : MonoBehaviour
{
    public GameObject laser;
    public GameObject superLaser;
    public BirdScript bird;
    public AudioSource laserSound;
    public AudioSource superLaserSound;
    public AudioSource charging;
    public float totalCharge = 0f;
    public float totalChargeNeeded;

    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        if (bird.birdIsAlive)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                fireLaser();
            }

            if (Input.GetKeyDown(KeyCode.X))
            {
                charging.Play();
            }
            if (Input.GetKey(KeyCode.X))
            {
                totalCharge += Time.deltaTime;
            }
            if (Input.GetKeyUp(KeyCode.X))
            {
                fireSuperLaser();
            }
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
        if (totalCharge >= totalChargeNeeded)
        {
            float birdPositionX = bird.getPositionX();
            float birdPositionY = bird.getPositionY();
            Instantiate(superLaser, new Vector3(birdPositionX, birdPositionY, 0), transform.rotation);
            superLaserSound.Play();
        }
        totalCharge = 0f;
    }
    
}
 