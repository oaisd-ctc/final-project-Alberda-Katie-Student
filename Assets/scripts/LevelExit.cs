using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LevelExit : MonoBehaviour
{
    [SerializeField] float levelLoadDelay = 1f;
    void OnTriggerEnter2D(Collider2D other) 
    {
        int currectSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currectSceneIndex +1);
        StartCoroutine(LoadNextLevel());
       
    }
    IEnumerator LoadNextLevel()
    {
        yield return new WaitForSecondsRealtime(levelLoadDelay);
        int currectSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currectSceneIndex +1);

    }
	


}
