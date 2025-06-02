using UnityEngine;

public class CatObj : MonoBehaviour
{
	public void FirstGrab()
	{
		GetComponent<Rigidbody>().useGravity = true;
	}
	public void DebugMessage()
	{
		Debug.Log("Focus Exended");
	}

	public void DebugSelected()
	{
		Debug.Log("Selected");
	}
}
