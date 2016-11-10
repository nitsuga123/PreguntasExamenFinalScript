using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class volumen : MonoBehaviour {

    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<AudioSource>().volume = gameObject.GetComponent<Slider>().value;

	}


}
