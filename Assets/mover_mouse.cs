using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_mouse : MonoBehaviour
{
    /*
        makes an object appear and dissappear by mouse clicking
    */

   
    [SerializeField]
    private bool mouse_enable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.GetComponent<Renderer>().enabled)
            {
                gameObject.GetComponent<Renderer>().enabled = false;
            }
            else
            {
                gameObject.GetComponent<Renderer>().enabled = true;
            }

        }
    }



}