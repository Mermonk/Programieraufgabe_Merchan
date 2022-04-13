using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Sphere : MonoBehaviour
{
    public Color Farben;
    public float rfloat;
    public float gfloat;
    public float bfloat;
    public float afloat;

   
    public int A;

    //0-1
   

    public Renderer myrenderer;

    
    // Start is called before the first frame update
    void Start()
    {

        afloat = 1;
        myrenderer = gameObject.GetComponent<Renderer>();
        transform.Translate(Vector3.forward);
         


    }

    // Update is called once per frame
    void Update()
    {
        

            if (Input.GetKeyDown(KeyCode.Space))
        {

            GetComponent<Rigidbody>().AddForce(Vector3.up * 5, ForceMode.VelocityChange);
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            A++;

            //blau
            if (A == 1)
            {
                rfloat = 0;
                gfloat = 0;
                bfloat = 1;
                afloat = 1;

            }
            //gelb
            else if (A == 2) 
            {
                rfloat = 1;
                gfloat = 0.92f;
                bfloat = 0.016f;
                afloat = 1;
            }
            //rot
            else if (A == 3) 
            {
                rfloat = 1;
                gfloat = 0;
                bfloat = 0;
                afloat = 1;
            }
            else 
            //white
            {
                rfloat = 1;
                gfloat = 1;
                bfloat = 1;
                afloat = 1;
                A = 0;

            }


            Farben = new Color(rfloat, gfloat, bfloat, afloat);
            myrenderer.material.color = Farben;



        }

    }
}
