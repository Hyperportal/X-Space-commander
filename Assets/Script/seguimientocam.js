#pragma strict

var jugador : Transform;
var smooth = 2.0;


function Start () {

jugador = GameObject.FindGameObjectWithTag("Player").transform; 


}

function Update () {

    var pos = Camera.main.WorldToScreenPoint(transform.position);
    var dir = Input.mousePosition ;
    var angle = Mathf.Atan2(dir.y  , dir.x ) * Mathf.Rad2Deg;


    var target = Quaternion.Euler (0 , 0, 0);
 
transform.position.y = jugador.position.y  + 8; 
transform.position.x = jugador.position.x ; 
transform.position.z = jugador.position.z - 25; 
transform.rotation.y = jugador.rotation.y;


//transform.rotation = Quaternion.AngleAxis( jugador.rotation.y , Vector3.up);


//transform.localEulerAngles =new Vector3(0, jugador.rotation.y ,0);

}