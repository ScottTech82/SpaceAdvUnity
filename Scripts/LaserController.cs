using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    [Header("Movement Variables")]
    public float speed;
    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        myRigidbody.velocity = new Vector2(0f, speed);

    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
