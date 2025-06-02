using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHandOnInput : MonoBehaviour
{

	public InputActionProperty pinchAnimationAction;
	public InputActionProperty gripAnimationAction;

	public Animator handAnimation;

	private void Update()
	{
		float triggerValue = pinchAnimationAction.action.ReadValue<float>();
	    handAnimation.SetFloat("Trigger",triggerValue);

		float gripValue = gripAnimationAction.action.ReadValue<float>();
		handAnimation.SetFloat("Grip", gripValue);

		//Debug.Log(triggerValue);
	}
}
