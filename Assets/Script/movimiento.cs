
using UnityEngine;
using System.Collections;

public class movimiento : MonoBehaviour {

    public GameObject terreno ;
    private bool envuelo;
    public int altitud;
    public int Gravedad; 

    // Use this for initialization
    void Start () {

        // terreno = GameObject.FindGameObjectsWithTag("Terreno")[0];

        Physics.gravity = new Vector3(0, Gravedad, 0);


    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(0, 0, Input.GetAxis("Vertical") / 3);
        transform.Rotate(0, Input.GetAxis("Horizontal") * 2, 0);

        if (transform.position.y < terreno.transform.position.y - 1)
        {
            //transform.Translate( transform.position.x + 2,0,0);

            transform.position = new Vector3(transform.position.x, transform.position.y + 1, transform.position.z);

        }

        if (Input.GetKeyDown("space"))
        {

            if(envuelo==false)
            {
                transform.Translate(Vector3.up * altitud , Space.World);
                envuelo = true;
            }

            Debug.Log("JUMP");

        }

     


    }

    void OnCollisionEnter(Collision col)
    {
        //this.transform.position = new Vector3(0, -5f, 0);
        envuelo = false; 
        Debug.Log("HIT");

    }
}
