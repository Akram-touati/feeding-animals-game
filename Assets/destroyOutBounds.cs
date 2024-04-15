using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOutBounds : MonoBehaviour
{
    private float lowerBound = -32.0f;
    private float upperBound = 32.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {   // if an obejct get past the player view in the game remove that obejct
        if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > upperBound)
        {
            Destroy(gameObject);
            Debug.Log("Game Over");
        }
    }
}
