using PrimeTween;
using UnityEngine;

public class BounceObjAnim : MonoBehaviour
{
	[SerializeField] private float _strengOfBounce = -0.5f;
	private void OnEnable()
	{
		Tween.LocalPositionY(transform,_strengOfBounce,1f,Ease.InOutCubic,-1,CycleMode.Rewind);
	}
}
