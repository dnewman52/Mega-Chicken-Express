using UnityEngine;
using System.Collections;

public class CameraFlip : MonoBehaviour {
    Transform topDownTransform;
    public Transform sideScrollTransform;
    public float smoothVal = 5f;
    bool flipped = false;
    

    // Use this for initialization
    void Awake()
    {

        topDownTransform = Camera.main.transform; //GetComponent<Transform>();
        sideScrollTransform = GetComponent<Transform>();
    }


    void Start() { }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        { 
        if(!flipped)
            { 
                Vector3.Lerp(topDownTransform.position, sideScrollTransform.position, smoothVal * Time.deltaTime);
                flipped = true;
            }
        else
            {
                Vector3.Lerp(sideScrollTransform.position, topDownTransform.position, smoothVal * Time.deltaTime);
                flipped = false;
            }
        }
    }


/*
    void FlipCam()
    {
        if (!flipped)
        {
            Vector3.Lerp(topDownTransform.position, sideScrollTransform.position, smoothVal * Time.deltaTime);
            flipped = true;
        }
        else
        {
            Vector3.Lerp(sideScrollTransform.position, topDownTransform.position, smoothVal * Time.deltaTime);
            flipped = false;
        }


    }
*/
}
