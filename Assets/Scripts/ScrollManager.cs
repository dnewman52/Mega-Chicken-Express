using UnityEngine;
using System.Collections;

public class ScrollManager : MonoBehaviour {

    public static float ScrollSpeed=0f;
    public float time=0f;
    public AnimationCurve curve;
    // Use this for initialization
	void Start () {


    }
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;
        ScrollManager.ScrollSpeed = -curve.Evaluate(time);
    }

}
