using NUnit.Framework;
using PrimeTween;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameStart : MonoBehaviour
{
	[SerializeField] List<Transform> _wallList;

	[SerializeField] Transform _head;

	[SerializeField] TMP_Text _Text;

	[SerializeField] RoomAnimation _secondRoom;

	public void StarRoomDisapearAnim()
	{
		Tween.Scale(_head, 0, 2f, Ease.InOutBounce).OnComplete(() => CompleteAnim());
		foreach (Transform t in _wallList)
		{
			Tween.ShakeLocalPosition(t, new Vector3(0.1f, 0.1f, 0.1f), 2f, easeBetweenShakes: Ease.InOutBounce).Group(Tween.PositionY(t, -5.5f, 2f));
		}

	}

	private void CompleteAnim()
	{
		_head.gameObject.SetActive(false);
		foreach (Transform t in _wallList)
		{
			t.gameObject.SetActive(false);
		}

		_secondRoom.AppearRoom();
		_Text.text = "GO GO GO !!!";
	}
}
