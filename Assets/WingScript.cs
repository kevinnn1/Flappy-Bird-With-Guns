using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingScript : MonoBehaviour
{
    public BirdScript bird;
    public Sprite wingDown;
    public SpriteRenderer spriteRenderer;
    public Sprite wingUp;

    // Start is called before the first frame update
    void Start()
    {
        bird = GameObject.FindGameObjectWithTag("Bird").GetComponent<BirdScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            changeSprite(wingDown);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            changeSprite(wingUp);
        }
    }
    void changeSprite(Sprite newSprite)
    {
        spriteRenderer.sprite = newSprite;
    }

}
