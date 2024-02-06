using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superLaserScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = Vector2.right * speed;
    }
}
