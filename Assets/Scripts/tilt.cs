﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilt : MonoBehaviour
{
    public GameObject beaker;
    public GameObject beaker1pos;
    public GameObject testubepos;
    public GameObject pipettepos;
    public GameObject beaker2pos;
    public GameObject beaker2;
    public GameObject tube;
    public GameObject cylinder;
    public GameObject cylinder2;
    public GameObject particles;
    public GameObject particles2;
    public GameObject particles3;
    //public Collider boxka;
    //public Collider funnelka;
    public GameObject button;
    public GameObject button2;
    public GameObject startbutton;
    public GameObject stopbutton;
    public GameObject pipettbutton;
    public GameObject pipettecylinder;
    public GameObject pipette;
    private float timedelay = 6;
    public filling fscript;
    public GameObject reset;
    private int count = 0;

    public void FillPipette()
    {
        StartCoroutine(PipetteFilling());
    }
    
    private IEnumerator PipetteFilling()
    {
        while (true)
        {
            if (timedelay > 0)
            {
                timedelay -= Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            else if (cylinder.transform.localScale.y > 0.38f)
            {
                particles.SetActive(false);
                beaker.SetActive(false);
                button.SetActive(false);
                pipettbutton.SetActive(true);

                yield return new WaitForEndOfFrame();
            }
            if (cylinder2.transform.localPosition.y > -0.283)
            {
                Debug.Log("isrunning");
                pipette.SetActive(false);
                pipettecylinder.SetActive(false);
                tube.SetActive(false);
                particles2.SetActive(false);
                particles3.SetActive(false);
                button2.SetActive(false);
                startbutton.SetActive(true);
                stopbutton.SetActive(true);
                reset.SetActive(true);
                yield return new WaitForEndOfFrame();


            }
            if (pipettecylinder.transform.localScale.y > 0.042f)
            {
                beaker2.SetActive(false);
                pipettbutton.SetActive(false);
            }
            else
            {
                break;
            }
        }
        yield return null;
    }
    public void tilting()
    {
        this.gameObject.SetActive(false);
        beaker.transform.localPosition = beaker1pos.transform.localPosition;
            
        beaker.transform.Rotate(0.0f, 0.0f, -60.0f, Space.Self);
           
        particles.SetActive(true);
        fscript.startfilling();

    }
    public void fillflask()
    {
        
        tube.transform.localPosition = testubepos.transform.localPosition;
        tube.transform.Rotate(0.0f, 0.0f, -60.0f, Space.Self);
   
        pipette.transform.localPosition = pipettepos.transform.localPosition;
        pipette.transform.Rotate(0.0f, 0.0f, -65.0f, Space.Self);
       
        cylinder2.SetActive(true);
        particles2.SetActive(true);
        particles3.SetActive(true);
        pipettecylinder.SetActive(false);
        this.gameObject.SetActive(false);
        
    }
    public void fillpipette()
    {
        this.gameObject.SetActive(false);
        beaker2.transform.localPosition = beaker2pos.transform.localPosition;
        pipettecylinder.SetActive(true);
        //button2.SetActive(true);
        
    }

}
