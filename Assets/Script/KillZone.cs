using UnityEngine;

public class KillZone : MonoBehaviour
{
	[SerializeField] Transform _checkPoint;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			other.gameObject.GetComponent<Transform>().position = _checkPoint.position;
		}
	}
}
