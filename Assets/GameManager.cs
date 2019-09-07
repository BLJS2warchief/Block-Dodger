using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public float Slowness = 10f;

    public void EndGame()
    {
        StartCoroutine("RestartLevel");
        Debug.Log("Ending Game!!!");
    }

    IEnumerator RestartLevel()
    {
        Time.timeScale = 1f / Slowness;
        Time.fixedDeltaTime /= Slowness;
        Debug.Log("cvbjuygbnjuyg");
        yield return new WaitForSeconds(1f / Slowness);

        Time.timeScale = 1f;
        Time.fixedDeltaTime *= Slowness;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
