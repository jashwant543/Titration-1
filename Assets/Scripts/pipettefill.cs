using UnityEngine;

public class pipettefill : MonoBehaviour
{
    private Vector3 target = new Vector3(0.3243f, -0.042f, -0.0304f);
    private float speed = 0.5f;
    private Vector3 scale1 = new Vector3(0.0112f, 0.0429269f, 0.0112f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
        transform.localScale = Vector3.Lerp(transform.localScale, scale1, Time.deltaTime * 0.5f);
    }
}
