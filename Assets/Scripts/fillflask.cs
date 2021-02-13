using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fillflask : MonoBehaviour
{
    private Vector3 target = new Vector3(0.0802f, -0.2757f, 0.0258f);
    private float speed = 0.5f;
    private bool isFull = false;
    // Start is called before the first frame update
    void Start()
    {
        
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
                transform.localScale += new Vector3(0, 0, speed) * Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
        
            else
            {

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

}
