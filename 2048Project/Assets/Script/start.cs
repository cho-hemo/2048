using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    float _Sec;
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        _Sec += Time.deltaTime;
        if (_Sec > 2)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
    
}
