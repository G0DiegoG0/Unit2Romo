using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float calmDownDog = 0.0f;
    private float callDogPause = 1.5f;
    // Update is called once per frame
    void Update()
    {
        calmDownDog += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && calmDownDog >= callDogPause)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            calmDownDog = 0.0f;
        }
    }
}
