using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float leftLimit = 30;
    private float bottomLimit = -5;
   
    // Update is called once per frame
    void Update()
    {
        //If an object goes past the players view in the game, remove that object
        if (transform.position.z > leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
    }
}
