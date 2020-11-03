using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_heart : MonoBehaviour
{
    /*
       A beating heart back and forth
    */

    private double count = 1.0;
    private float value = 0.01f;
    [SerializeField]
   
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-13, 5, 0);   //start position
        transform.localScale = new Vector3(1,1,0)* value;

    }

    // Update is called once per frame
    void Update()
    {
  
        if (count >= 0 && count <= 50)
        {
            count += 1;
            transform.localScale += new Vector3(1,1,0)*value;
        }
        else if (count < 0)
        {
            count += 1;
            transform.localScale -= new Vector3(1,1,0)*value;
        }
        else
        {
            count = -50;
        }
    }
}
   
