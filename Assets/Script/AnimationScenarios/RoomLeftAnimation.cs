using NUnit.Framework;
using PrimeTween;
using System.Collections.Generic;
using UnityEngine;

public class RoomAnimation : MonoBehaviour
{
	[SerializeField] List<Transform> _animObjList;

	public void DisapearRoom()
	{
		foreach (Transform t in _animObjList)
		{
			t.gameObject.SetActive(true);
			Tween.Scale(t,1f, 0.001f, 1f,Ease.InOutBounce).OnComplete(() => t.gameObject.SetActive(false));
		}
	}

	public void AppearRoom()
	{
		foreach (Transform t in _animObjList)
		{
			t.gameObject.SetActive(true);
			Tween.Scale(t,0.1f, 1f, 1f, Ease.InOutExpo);
		}
	}
}
