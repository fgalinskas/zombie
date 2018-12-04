using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class carregamento : MonoBehaviour
{
    AsyncOperation aop;
    public SpriteRenderer srend;
    float timer = 0;
    // Use this for initialization
    void Start()
    {
        Time.timeScale = 1;
        aop = SceneManager.LoadSceneAsync(persistence.nextLevel);
        aop.allowSceneActivation = false;

    }

    // Update is called once per frame
    void Update()
    {
        print(timer);
        if (timer < 0.89f)
        {
            timer = Mathf.Lerp(timer, aop.progress, Time.deltaTime * 5);
            srend.size = new Vector2(timer * 11, srend.size.y);
        }
        else
        {
            aop.allowSceneActivation = true;
        }
    }
}
