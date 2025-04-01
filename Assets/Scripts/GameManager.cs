using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] protected GameObject _panel;

    protected virtual void OnTriggerEnter2D(Collider2D collision) => _panel.SetActive(true);

    public void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    public void Pause() => Time.timeScale = Time.timeScale == 0 ? 1 : 0;
}
