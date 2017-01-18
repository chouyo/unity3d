using UnityEngine;
using System.Collections;

public class DesctroyByTime : MonoBehaviour {

    public float liftTime;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, liftTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
