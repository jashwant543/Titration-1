using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

[RequireComponent(typeof(ARRaycastManager))]
public class ARTapToPlace : MonoBehaviour
{
    public GameObject ObjectToPlace;

    private GameObject SpawnedObject;
    private ARRaycastManager _arRaycastManager;
    private Vector2 TouchPosition;

    static List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    private void Awake()
    {
        _arRaycastManager = GetComponent<ARRaycastManager>();
    }

    bool TryGetTouchPosition(out Vector2 TouchPosition)
    {
        if(Input.touchCount > 0)
        {
            TouchPosition = Input.GetTouch(0).position;
        }

        TouchPosition = default;
        return false;
    }
    // Update is called once per frame
    void Update()
    {
        if (!TryGetTouchPosition(out Vector2 TouchPosition))
            return;

        if(_arRaycastManager.Raycast(TouchPosition, hits, TrackableType.PlaneWithinPolygon))
        {
            var HitPose = hits[0].pose;

            if(SpawnedObject == null)
            {
                SpawnedObject = Instantiate(ObjectToPlace, HitPose.position, HitPose.rotation);
            }

        }
    }
}
