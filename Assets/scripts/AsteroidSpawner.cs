using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject prefabAsteroids;
    float radius;

    // Use this for initialization
    void Start()
    {
        
        GameObject newAsteroid = Instantiate(prefabAsteroids);
        Vector3 position = new Vector3(0, 0);
        newAsteroid.GetComponent<Asteroid>().Initialize(Direction.Up,position);
        radius = newAsteroid.GetComponent<CircleCollider2D>().radius;
        Destroy(newAsteroid);

        Vector3 LocationTop = new Vector3(0, ScreenUtils.ScreenTop + radius, 0);
        Vector3 LocationRight = new Vector3(ScreenUtils.ScreenRight + radius, 0, 0);
        Vector3 LocationBottom = new Vector3(0, ScreenUtils.ScreenBottom - radius, 0);
        Vector3 LocationLeft = new Vector3(ScreenUtils.ScreenLeft - radius, 0, 0);

        GameObject newAsteroidBottom = Instantiate(prefabAsteroids);
        newAsteroidBottom.GetComponent<Asteroid>().Initialize(Direction.Up, LocationBottom);

        GameObject newAsteroidTop = Instantiate(prefabAsteroids);
        newAsteroidTop.GetComponent<Asteroid>().Initialize(Direction.Down, LocationTop);

        GameObject newAsteroidRight = Instantiate(prefabAsteroids);
        newAsteroidRight.GetComponent<Asteroid>().Initialize(Direction.Left, LocationRight);

        GameObject newAsteroidLeft = Instantiate(prefabAsteroids);
        newAsteroidLeft.GetComponent<Asteroid>().Initialize(Direction.Right, LocationLeft);
    }
	
	
}
