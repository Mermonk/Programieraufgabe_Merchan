using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wurfel : MonoBehaviour

{

    public Color Farben;
    public float rfloat;
    public float gfloat;
    public float bfloat;
    public float afloat;
    public int A;
    public Renderer myrenderer;

    public float rotateamount;
    public bool links;


    // Start is called before the first frame update
    void Start()
    {
        afloat = 1;
        myrenderer = gameObject.GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()

    {
        if (links)
        {
            transform.Rotate(Vector3.up * rotateamount);
        }
        else
        {
            transform.Rotate(Vector3.down * rotateamount);
        }
        if (Input.GetKeyDown(KeyCode.Space))
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
