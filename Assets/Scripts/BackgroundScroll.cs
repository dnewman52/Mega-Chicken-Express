using UnityEngine;
using System.Collections;

public class BackgroundScroll : MonoBehaviour {

    public float scrollSpeed;
    public float tileSizeZ;
    public float multi = 1.0f;
    private Vector3 startPosition;
    public float scrollSize;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        
        scrollSpeed = ScrollManager.ScrollSpeed*multi;
        //float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
        //transform.position = startPosition + Vector3.right * newPosition;
        for (int i = 0; i < transform.childCount; i++)
        {
            
            Transform child = transform.GetChild(i);
            child.localPosition += Vector3.left * scrollSpeed*Time.deltaTime;
            if (child.localPosition.x > 0) {
                child.localPosition -= Vector3.right*scrollSize;
            }
        }
    }
}
