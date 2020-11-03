using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class movelilo : MonoBehaviour
{
    float stepSize = 1f;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, stepSize, 0);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, -stepSize, 0);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(stepSize, 0, 0);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-stepSize, 0, 0);
        }
    }
}
