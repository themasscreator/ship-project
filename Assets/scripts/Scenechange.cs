using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenechange : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.name == "main ship")
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

		}
	}
}