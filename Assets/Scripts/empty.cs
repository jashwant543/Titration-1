using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty : MonoBehaviour
{    
    private bool isfull = false;
    private float speed = 0.1f;
    public GameObject acid;
    //private GameObject KMnO4;


    void Start()
    {
        //KMnO4 = GameObject.Find("Burette/burette/Kmno4");
    }
    public void resetexp()
    {
        acid.gameObject.GetComponent<Renderer>().material.color = Color.clear;
    }

   
}
