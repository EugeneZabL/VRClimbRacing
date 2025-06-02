using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	private float _timer = 0;

	private bool _isTimerStart = false;

	[SerializeField] private List<TMP_Text> _timersText;

	private void Update()
	{
		if (_isTimerStart)
			_timer += Time.deltaTime;

		foreach (TMP_Text text in _timersText)
			text.text = GetActualTime();
	}
	public string GetActualTime()
	{
		int minutes = Mathf.FloorToInt(_timer / 60f);
		int seconds = Mathf.FloorToInt(_timer % 60f);
		int milliseconds = Mathf.FloorToInt((_timer * 1000f) % 1000f);

		return string.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, milliseconds);

	}

	public string GetBestTime()
	{
		float bestTime = PlayerPrefs.GetFloat("BestTime");
		if (bestTime <= 0)
			bestTime = _timer;

		int minutes = Mathf.FloorToInt(bestTime / 60f);
		int seconds = Mathf.FloorToInt(bestTime % 60f);
		int milliseconds = Mathf.FloorToInt((bestTime * 1000f) % 1000f);

		return string.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, milliseconds);

	}

	public void StartGame()
	{
		_isTimerStart=true;
	}

	public void EndGame()
	{
		_isTimerStart =false;

		float bestTime = PlayerPrefs.GetFloat("BestTime");
		if (bestTime > _timer)
			PlayerPrefs.SetFloat("BestTime",_timer);
	}

	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
