
using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        transform.Translate(0 , 0, Input.GetAxis("Vertical"));
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);
   
    }

    /*void OnCollisionEnter(Collision col)
    {
        this.transform.position = new Vector3(0, -5f, 0);
    }*/

}
