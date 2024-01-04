using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet_move : MonoBehaviour

{
    Renderer kill_renderer; // tell system I will use "Renderer" in name "kill_renderer"
    // Start is called before the first frame update
    void Start()
    {
        kill_renderer = GetComponent<Renderer>(); //kill_renderer use component in Renderer 
    }

    // Update is called once per frame
    void Update()
    {

        if(!kill_renderer.isVisible) //If it is not visible destroy it 
        {

            Destroy(gameObject);
        }
    } 
}

//Done Ez