using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Satsuki Yamamoto
//Asteroids S&D
//Math&Physics
//11/16/2018

public class Asteroid : MonoBehaviour
{

    [SerializeField]
    Sprite[] prefabAsteroids = new Sprite[3];

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = prefabAsteroids[Random.Range(0, 3)];
    }

    public void Initialize(Direction AsteroidDirection, Vector3 location)
    {
        const float MinImpulseForce = 0.5f;
        const float MaxImpulseForce = 1f;
        float angle = 0;
        
        if(AsteroidDirection == Direction.Up)
        {
            angle = (Random.Range(0,31) + 75) * Mathf.Deg2Rad;
        }
        else if(AsteroidDirection == Direction.Right)
        {
            angle = (Random.Range(0,31) + 345) * Mathf.Deg2Rad;
        }
        else if(AsteroidDirection == Direction.Down)
        {
            angle = (Random.Range(0,31) + 255) * Mathf.Deg2Rad;
        }
        else if(AsteroidDirection == Direction.Left)
        {
            angle = (Random.Range(0,31) + 165) * Mathf.Deg2Rad;
        }
        transform.position = location; 
        Vector2 moveDirection = new Vector2(Mathf.Cos(angle), Mathf.Sin(angle));
        float magnitude = Random.Range(MinImpulseForce, MaxImpulseForce);
        GetComponent<Rigidbody2D>().AddForce(moveDirection * magnitude, ForceMode2D.Impulse);
    }
}
