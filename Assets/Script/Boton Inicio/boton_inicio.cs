using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class boton_inicio : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }



    public void OnMouseDown()
    {
        SceneManager.LoadScene("sandbox");
    }


    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("sandbox");
        }

    }

}
