using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour
{
    [SerializeField] Text timeText;
    bool timeActive = true;
    float second;
    int minute;
    int hour;
    public GameObject Quit;
    // Start is called before the first frame update

    void Start()

    {


    }



    // Update is called once per frame

    void Update()

    {

        StartTime();
        if (Quit.activeSelf == true)
        {
            timeActive = false;
        }



    }
    void StartTime()
    {
        if (timeActive)
        {
            second += Time.deltaTime;
            timeText.text = string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, (int)second);

            if ((int)second > 59)
            {
                second = 0;
                minute++;

                if (minute > 59)
                {
                    minute = 0;
                    hour++;
                }
            }

        }

    }
}
