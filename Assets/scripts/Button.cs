using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
  void start() 
  {
    GetComponent<Button>();
    int currectSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currectSceneIndex +1);
  }

    void Update() 
    {
        
        int currectSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currectSceneIndex +1);
    
    }

    
}
