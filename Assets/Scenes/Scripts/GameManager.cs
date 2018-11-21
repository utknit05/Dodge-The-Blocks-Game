using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public float slowness = 2f;

    public Text score;

    public void EndGame() {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel(){
        Time.timeScale = Time.timeScale / slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime / slowness;

        yield return new WaitForSeconds(1f / slowness);

        Time.timeScale = Time.timeScale * slowness;
        Time.fixedDeltaTime = Time.fixedDeltaTime * slowness;

        score.text = "0";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
