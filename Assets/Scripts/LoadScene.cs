using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    [SerializeField] int timeToWait = 4;
    int currentSceneIndex;

        private void Start()
    {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0)
        {
            StartCoroutine(WaitAndLoad());
        }
    }


    IEnumerator WaitAndLoad()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadYouLose()
    {
        SceneManager.LoadScene("Lose Scene");
    }

}
