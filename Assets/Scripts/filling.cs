using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class filling : MonoBehaviour
{
    
    [SerializeField]private float speed = 0.001f;
    bool isfull = false;
    bool isemptying = false;
    public Vector3 originalscale;
    public GameObject acid;
    bool colorchanged = false;
    public GameObject fillbuettebut;
    public GameObject fillpipettebut;
    public GameObject particles;
    public GameObject beaker;
    private float ColorChangeTime;

    void Start()
    {
        originalscale = this.transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void startfilling()
    {
        StartCoroutine(fillliquid());
    }
    public IEnumerator fillliquid()
    {

        while (true)
        {
            if (!isfull)
            {
                transform.localScale += new Vector3(0, speed, 0) * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            else
            {
                colorchanged = false;
                break;
            }
            if(this.transform.localScale.y > 0.838f)
            {
                particles.SetActive(false);
                fillbuettebut.SetActive(false);
                fillpipettebut.SetActive(true);
                beaker.SetActive(false);
            }
        }
        yield  return null;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Burette Full");
        if(other.gameObject.name == "0mlTrigger")
        {
            isfull = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Burette Full");
        if(other.gameObject.name == "0mlTrigger")
        {
            isfull = false;
        }
    }
    public void emptyburette(bool status)
    {
        isemptying = status;
        StartCoroutine(emptyliquid());
    }
    public IEnumerator emptyliquid()
    {
        ColorChangeTime = 0;
        while (true)
        {
            if (isemptying && this.transform.localScale.y > originalscale.y)
            {

                transform.localScale -= new Vector3(0, speed, 0) * Time.deltaTime;

                ColorChangeTime += Time.deltaTime;

                if (/*this.transform.localScale.y < 0.657054f*/ ColorChangeTime > 3 && !colorchanged)
                {
                    changeacidcolor();
                }

                yield return new WaitForEndOfFrame();
            }
            else if(!isemptying || this.transform.localScale.y < originalscale.y)
            {
                colorchanged = false;
                ColorChangeTime = 0;
                break;
            }

        }
        yield return null;
    }
    public void changeacidcolor()
    {
        acid.gameObject.GetComponent<Renderer>().material.color = Color.magenta;
        //acid.gameObject.GetComponent<Renderer>().material.color.a = 0.5f;
        //acid.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.2f);
        colorchanged = true;
    }
    

}
