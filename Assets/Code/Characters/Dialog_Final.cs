using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.SceneManagement;

public class Dialog_Final : MonoBehaviour
{
	public NPC_Task npc_tallkScript;
	public GameObject Text1;
	public GameObject Name;
	public GameObject Press1;
	public GameObject Press2;

	private bool isText1 = true;
    private loading_scene_slider loadingSceneSlider;

	public void Start()
    {
		Text1.SetActive(true);
		Press1.SetActive(true);
		Press2.SetActive(true);
		Name.SetActive(true);
	}

	public void Update()
	{
		if (Input.GetKey("r"))
		{
			isText1 = false;
			Text1.SetActive(true);
			Press1.SetActive(true);
			Press2.SetActive(true);
			Name.SetActive(true);
			npc_tallkScript.EndDialog = true;
			npc_tallkScript.Dialog2.SetActive(false);
			npc_tallkScript.gameObject.GetComponent<Animator>().SetBool("Talking", false);
		}

		if (Input.GetKey("f"))
		{
      		SceneManager.LoadScene("Loading");
      		loading_scene_slider.sceneID = 3;
		}

	}
}
