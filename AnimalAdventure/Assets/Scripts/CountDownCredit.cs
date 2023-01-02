using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDownCredit : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 21;

    private float timeElapsed;
    void Update()
    {
        timeElapsed += Time.deltaTime;
        if (timeElapsed > delayBeforeLoading)
        {
            LoadStartScene();  
        }
    }
    public void LoadStartScene()
    {
        //LoadingScene.instance.ChangSceneOnClick(0);
        SceneManager.LoadScene("StartScene");
    }
}
