#pragma strict
  
 var objectToOrbit : Transform; //Object To Orbit
 var orbitAxis : Vector3 = Vector3.up; //Which vector to use for Orbit
 var orbitRadius : float = 75.0; //Orbit Radius
 var orbitRadiusCorrectionSpeed : float = 0.5; //How quickly the object moves to new position
 var orbitRoationSpeed : float = 0.2; //Speed Of Rotation arround object
 var orbitAlignToDirectionSpeed : float = 0.1; //Realign speed to direction of travel
 
 private var orbitDesiredPosition : Vector3;
 private var previousPosition : Vector3;
 private var relativePos : Vector3;
 private var rotation : Quaternion;
 private var thisTransform : Transform;
 
 //---------------------------------------------------------------------------------------------------------------------
 
 function Start() {    
     thisTransform = transform;
 }
 
 //---------------------------------------------------------------------------------------------------------------------
 
 function Update() {
     //Movement
     thisTransform.RotateAround (objectToOrbit.position, orbitAxis, orbitRoationSpeed * Time.deltaTime);
     orbitDesiredPosition = (thisTransform.position - objectToOrbit.position).normalized * orbitRadius + objectToOrbit.position;
     thisTransform.position = Vector3.Slerp(thisTransform.position, orbitDesiredPosition, Time.deltaTime * orbitRadiusCorrectionSpeed);
 
     //Rotation
     relativePos = thisTransform.position - previousPosition;
     rotation = Quaternion.LookRotation(relativePos);
     thisTransform.rotation = Quaternion.Slerp(thisTransform.rotation, rotation, orbitAlignToDirectionSpeed * Time.deltaTime);
     previousPosition = thisTransform.position;
 }