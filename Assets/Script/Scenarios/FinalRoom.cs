using TMPro;
using UnityEngine;

public class FinalRoom : MonoBehaviour
{
	[SerializeField] GameManager _gameManager;

	[SerializeField] TMP_Text _youScoreText,_bestScore;

	private void OnEnable()
	{
		_gameManager.EndGame();

		_youScoreText.text = _gameManager.GetActualTime();
		_bestScore.text = _gameManager.GetBestTime();
	}

	public void AgainButton()
	{
		_gameManager.RestartGame();
	}
}
