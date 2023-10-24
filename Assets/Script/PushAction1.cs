using UnityEngine;


public class PushAction : MonoBehaviour
{
	public Vector3 force = Vector3.up;
	public ForceMode forceMode = ForceMode.Impulse;
	public ForceMode2D forceMode2D = ForceMode2D.Impulse;

	public void Push(Rigidbody target)
	{
		target.AddForce(force, forceMode);
	}

	public void Push(Rigidbody2D target)
	{
		target.AddForce(force, forceMode2D);
	}
}
