using UnityEngine;

public class playerMovement : MonoBehaviour
{
  // Start is called before the first frame update
	public Rigidbody Rigidbody;
  
  public float forwardForce = 2000f;
  public float sidewaysForce = 500f;
  // Update is called once per frame
  void FixedUpdate()
  {
    // Add a forward force
		Rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

    if( Input.GetKey("d"))
    {
      Rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
    if( Input.GetKey("a"))
    {
      Rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }

    if(Rigidbody.position.y < -1)
    {
      FindObjectOfType<manageGame>().EndGame();
    }
  }
}
