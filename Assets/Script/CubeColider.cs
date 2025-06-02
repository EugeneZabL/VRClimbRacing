using PrimeTween;
using UnityEngine;

public class CubeColider : MonoBehaviour
{
	[SerializeField] private ThirdRoom _manager; 
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.CompareTag("Cat"))
			_manager.CubeHit(this);

	}

	public void DisapearAnim()
	{
		Tween.Scale(transform,0f,1f,Ease.InCubic).OnComplete(()=> Destroy(gameObject));
	}
}
