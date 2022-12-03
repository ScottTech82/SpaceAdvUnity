using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFireController : MonoBehaviour
{
    [Header("Fire Variables")]
    public Transform firePoint;
    public GameObject regularFire;
    public float fireWait;
    private float fireWaitSeconds;


    // Start is called before the first frame update
    void Start()
    {
        fireWaitSeconds = fireWait;

    }

    // Update is called once per frame
    void Update()
    {
        fireWaitSeconds -= Time.deltaTime;
        if(fireWaitSeconds <= 0)
        {
            Fire();
            fireWaitSeconds = fireWait;
        }
        
    }

    public void Fire()
    {
        Instantiate(regularFire, firePoint.position, Quaternion.identity);
    }
}
