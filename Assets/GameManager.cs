using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float slowtime = 10f;
    public void EndGame()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / slowtime;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowtime;
        yield return new WaitForSeconds(1f/slowtime);

        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowtime;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
