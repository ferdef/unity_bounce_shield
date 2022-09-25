using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Prefab;
    public float Speed;
    public int Counter;
    private Transform _transform;
    private int _currentCounter;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
           
        if( _currentCounter <= 0)
        {
            var newBall = Instantiate(Prefab, _transform.position, Quaternion.identity);

            var rigidBody = newBall.GetComponent<Rigidbody>();
            rigidBody.AddForce(transform.right * Speed);
            _currentCounter = Counter;
        }
        else
        {
            _currentCounter--;
        }
        
    }
}
