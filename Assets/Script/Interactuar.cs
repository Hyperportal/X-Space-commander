using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Interactuar : MonoBehaviour
{

    private TextMesh  npc_name;
    public string mitexto;
    public GameObject micajatexto; 
  

    void Start()
    {

        npc_name = micajatexto.GetComponent<TextMesh>();
        npc_name.text = name;

    }

    void Update()
    {

        

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            Physics.Raycast(ray, out hit);
            Debug.Log("Toca Coordenadas " + hit.point);

 

        }

    



    }

    void OnMouseOver()
    {
        print(gameObject.name);
    }

    void OnMouseDown()
    {
        
        npc_name.text = name + ": "+ mitexto;
        //yield WaitForSeconds(2);
        //npc_name.text = name;
    }

}

