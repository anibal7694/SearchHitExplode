#pragma strict
private var plugin: RazerHydraPlugin = new RazerHydraPlugin();
var id1: int = 0;
var id2: int = 1;
var myCamera:Transform;
var controller: CharacterController;
var speed : int = 3;
var fireball:GameObject;
var timeBeforeNextFire: float = 0.0;
var fireRate : float = 0.5;
var shootForce : int = 40;
var count : int;
public var GameOverText: UnityEngine.UI.Text;
private var colliding: boolean;
private var ballcounter: int;
private var timeLeft: float = 10.0f; 
function Start(){
plugin.init();
	if(!fireball)
		fireball = transform.Find("Fireball").gameObject;
	if(!fireball)
		Debug.LogError("No fireball!");
		fireball.active = false;
	if(!myCamera)
		myCamera = transform.Find("Camera");
	if(!myCamera)
		Debug.LogError("No Camera!");
	if(!controller)
		controller = GetComponent(CharacterController);
	if(!controller)
		Debug.LogError("No Controller!");
	count = 0;
	colliding = false;
	Cursor.visible = false; 
	ballcounter = 20;
	GameOverText.enabled = false;
}
function Update () {
	if(ballcounter >= 0)
	{
	
//right controller
		plugin.getNewestData(id2);
//axe y
		myCamera.transform.rotation.eulerAngles.x = -plugin.data.position.y/-2;
//axe X
		myCamera.transform.rotation.eulerAngles.y = plugin.data.position.x/-2;
//left controller
		plugin.getNewestData(id1);
		controller.SimpleMove(myCamera.transform.forward * plugin.data.joystick_y * speed * 3);
		controller.SimpleMove(myCamera.transform.right * plugin.data.joystick_x *speed *3);
	
		if(plugin.data.trigger > 0.8 && Time.time > timeBeforeNextFire)
		{
			var cloneFireball : GameObject = Instantiate (fireball,	myCamera.transform.position, myCamera.transform.rotation);
			cloneFireball.active = true;
			cloneFireball.GetComponent.<Rigidbody>().AddForce(myCamera.transform.forward *shootForce);
			timeBeforeNextFire = Time.time + fireRate;
			Destroy(cloneFireball, 3);
			ballcounter -= 1;
		}

	}
	else 
	{
		GameOverText.enabled = true;
		GameOverText.text = "GAME OVER!!" ;
		timeLeft -= Time.deltaTime;
		if(timeLeft <= 0)
		{
			Application.LoadLevel(8);
		}
	}
	/*if(plugin.data.GetData("ONE"))
	{
		plugin.getNewestData(id1);
		controller.SimpleMove(myCamera.transform.forward * plugin.data.joystick_y * speed *5);
		controller.SimpleMove(myCamera.transform.right * plugin.data.joystick_x *speed *5);
	}*/
	
	/*if(colliding == true)
	{
		++count;
		setCountText();
	}*/

}
/*function setCountText()
{
	countText.text = "Count: " + count.ToString();
}
function OnCollisionEnter(collision: Collision)
{
	if(collision.gameObject.CompareTag("target"))
	{
		
		colliding = true;
		Destroy(this.gameObject);
	}
}*/