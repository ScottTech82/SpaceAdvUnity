using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    [Header("Player Movement")]
    public bool isControlling;
    public float controlMultiplier;
    private Vector2 mouseFirstPosition;
    private Vector2 mouseEndPosition;
    private Vector2 playerStartPosition;
    private Vector2 playerTargetPosition;
    private float xDiff;
    private float yDiff;

    // Start is called before the first frame update
    void Start()
    {
        isControlling = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            isControlling = true;
            mouseFirstPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            playerStartPosition = transform.position;
 
        }
        else if(Input.GetMouseButtonUp(0))
        {
            isControlling = false;
        }

        if(isControlling)
        {
            mouseEndPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            xDiff = (mouseEndPosition.x - mouseFirstPosition.x) * controlMultiplier;
            yDiff = (mouseEndPosition.y - mouseFirstPosition.y) * controlMultiplier;
            playerTargetPosition = new Vector2(playerStartPosition.x + xDiff, playerStartPosition.y + yDiff);
            transform.position = Vector2.Lerp(transform.position, playerTargetPosition,.2f);

        }

        float xPos = Mathf.Clamp(transform.position.x, -2.5f, 2.5f);
        float yPos = Mathf.Clamp(transform.position.y, -4.75f, 4.75f);
        transform.position = new Vector3(xPos, yPos, 0);

    }
}
