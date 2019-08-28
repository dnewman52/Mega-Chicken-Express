using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    public AnimationCurve curve;
    public float time;
    // Use this for initialization
    void Start () {
        curve = new AnimationCurve(new Keyframe(0, 0), new Keyframe(1, 5));
       
    }
	
	// Update is called once per frame
	void Update () {
        float v = curve.Evaluate(time);
        Debug.Log(v);
        transform.localScale = new Vector3(v, v, v);
    }
}
