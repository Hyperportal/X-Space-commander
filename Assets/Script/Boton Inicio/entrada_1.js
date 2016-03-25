import UnityEngine.SceneManagement;

#pragma strict

function Start () {
   
}


function Update () {

    if(Input.GetMouseButtonDown(0))
    {
        SceneManager.LoadScene("sandbox");
    }

}