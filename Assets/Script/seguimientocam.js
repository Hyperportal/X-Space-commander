#pragma strict

var jugador : Transform;
var smooth = 2.0;

var  turnSpeed  : float;

function Start () {

jugador = GameObject.FindGameObjectWithTag("Player").transform; 

turnSpeed = 1.40 ; 

}

function Update () {

 
 transform.rotation.y = jugador.rotation.y;
//transform.RotateAround(jugador.transform.position, Vector3.up, Input.GetAxis("Mouse X") * turnSpeed);
//transform.LookAt(jugador.position);

transform.position.y = jugador.position.y  + 10; 
transform.position.x = jugador.position.x ; 
transform.position.z = jugador.position.z -  20;
//transform.rotation = Quaternion.AngleAxis( jugador.rotation.y , Vector3.up);


//transform.localEulerAngles =new Vector3(0, jugador.rotation.y ,0);

}