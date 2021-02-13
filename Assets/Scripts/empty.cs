using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class empty : MonoBehaviour
{
    public filling fscript;
    public GameObject acid;
    public void resetexp()
    {
        fscript.startfilling();
        acid.gameObject.GetComponent<Renderer>().material.color = Color.clear;
    }
}
