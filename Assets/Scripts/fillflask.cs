using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fillflask : MonoBehaviour
{
    private Vector3 target = new Vector3(0.0802f, -0.2757f, 0.0258f);
    private float speed = 0.5f;
    private bool isFull = false;
    public GameObject startbutton;
    public GameObject stopbutton;
    public GameObject reset;
    public GameObject RefillBurette;
    public GameObject TTParticles;
    public GameObject PipetteParticles;
    private GameObject PipetteInitialPos;
    private GameObject TestTubeInitialPos;
    private GameObject Pipette;
    private GameObject TestTube;

    // Start is called before the first frame update
    void Start()
    {
        Pipette = GameObject.Find("Pipette");
        TestTube = GameObject.Find("TestTube");
        PipetteInitialPos = GameObject.Find("PipetteInitialPos");
        TestTubeInitialPos = GameObject.Find("TestTubeInitialPos");
    }

    // Update is called once per frame
    void Update()
    {
        //transform.localScale = Vector3.Lerp(transform.localScale, target, speed * Time.deltaTime);
    }

    public void FillFlask()
    {
        StartCoroutine(FlaskFilling());
    }

    private IEnumerator FlaskFilling()
    {
        while (true)
        {
            if (!isFull)
            {
                ResetAcid();
                yield return new WaitForEndOfFrame();
            }
        
            else
            {
                startbutton.SetActive(true);
                stopbutton.SetActive(true);
                reset.SetActive(true);
                RefillBurette.SetActive(true);
                TTParticles.SetActive(false);
                PipetteParticles.SetActive(false);
                Pipette.transform.position = PipetteInitialPos.transform.position;
                Pipette.transform.rotation = PipetteInitialPos.transform.rotation;
                TestTube.transform.position = TestTubeInitialPos.transform.position;
                TestTube.transform.rotation = TestTubeInitialPos.transform.rotation;
                break;
            }
        }
        yield return null;
    }

    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("colliding");
        if (other.gameObject.name == "20mlTrigger")
        {
            isFull = true;
        }
    }

    public void ResetAcid()
    {
        transform.localScale += new Vector3(0, 0, speed) * Time.deltaTime;
        
    }

}
