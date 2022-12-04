using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public enum states
    {
        straight, 
        wavy,
        loop
    }

    public states currentState;
    public float speed;

    [Header("Wavy Variables")]
    public float amplitude;
    public float period;
    public float shift;
    public float yChange;
    private float newX;
    private float newY;

    private Rigidbody2D myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //check for method of movement
        switch(currentState)
        {
            case states.straight:
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, -speed);
                break;
            case states.wavy:
                newY = transform.position.y - yChange;
                newX = amplitude * Mathf.Sin(period * newY) + shift;
                Vector2 tempPosition = new Vector2(newX, newY);
                transform.position = tempPosition;
                break;
            case states.loop:
                break;
            default:
                break;

        }


    }
}
