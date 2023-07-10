using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatScena : MonoBehaviour
{
    public GameObject npc;
    public GameObject videoScreen;
    public GameObject taskCanvas;
    public GameObject missionCompleteCanvas;
    public GameObject missionRepeatCanvas;

    private bool interactionComplete = false;
    private bool videoPlayed = false;
    private bool taskCompleted = false;

    private void Update()
    {
        // Проверяем, если игровой персонаж близко к NPC и нажимает кнопку "Взаимодействовать"
        if (Vector3.Distance(transform.position, npc.transform.position) <= 2f && Input.GetKeyDown(KeyCode.E))
        {
            if (!interactionComplete)
            {
                if (!videoPlayed)
                {
                    // Проигрываем видео на экране и выдаем задание игровому персонажу
                    PlayVideo();
                    GiveTask();
                }
                else
                {
                    if (!taskCompleted)
                    {
                        // Выводим текст повторения миссии на канвасе
                        ShowMissionRepeatText();
                    }
                    else
                    {
                        // Выводим текст о завершении миссии на канвасе
                        ShowMissionCompleteText();
                    }
                }
            }
        }   
    }

    private void PlayVideo()
    {
        // Проигрываем видео на экране
        videoScreen.SetActive(true);
        videoPlayed = true;
    }

    private void GiveTask()
    {
        // Выдаем задание игровому персонажу
        taskCanvas.SetActive(true);
        // Здесь можно добавить логику для установки текста задания на канвасе
    }

    private void ShowMissionRepeatText()
    {
        // Выводим текст повторения миссии на канвасе
        missionRepeatCanvas.SetActive(true);
        // Здесь можно добавить логику для установки текста повторения миссии на канвасе
    }

    private void ShowMissionCompleteText()
    {
        // Выводим текст о завершении миссии на канвасе
        missionCompleteCanvas.SetActive(true);
        // Здесь можно добавить логику для установки текста о завершении миссии на канвасе
    }
}


