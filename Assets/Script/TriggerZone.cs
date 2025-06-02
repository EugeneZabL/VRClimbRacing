using UnityEngine;

public class TriggerZone : MonoBehaviour
{
	[SerializeField] RoomAnimation _roomForApeear, _roomForDisapear;
 	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			if(_roomForApeear !=null)
				_roomForApeear.AppearRoom();
			if(_roomForDisapear != null)
				_roomForDisapear.DisapearRoom();

			Destroy(gameObject);
		}
	}
}
