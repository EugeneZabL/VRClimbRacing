using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit.Inputs.Readers;

public class CatSpawner : MonoBehaviour
{
	[SerializeField] CatObj _catPrefab;

	[SerializeField] Transform _spawnPosition;

	public void SummonCat()
	{
		Instantiate(_catPrefab, _spawnPosition.position, _spawnPosition.rotation);
	}
}
