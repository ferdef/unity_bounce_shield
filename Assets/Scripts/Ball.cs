using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((speed > 0 && transform.position.x < -16) || (speed < 0 && transform.position.x > 16))
        {
            Destroy(gameObject);
        }
    }
}
