using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_rotator : MonoBehaviour
{
    /*
     * An object called "Rotator" that rotates around itself at a given speed.
    */

    private float speed = 1f;
    [SerializeField] 
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(15, 6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.RotateAround(transform.position, new Vector3(0, 0, 1), 150*Time.deltaTime);
        
    }
}
