using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class menu : MonoBehaviour {
	public Button[] buttons;
    public Button continueBotao;
    
	//public string leveltogo;

	// Use this for initialization
	public void Start () {
        
        //carrega o arquivo salvo
        persistence.LoadData();

        //defini quem esta ativo baseado no loaddata
		for(int i =0; i<buttons.Length;i++){
			if (persistence.levelstatus [i] > 0) {
				buttons [i].interactable = true;

			} else {			
				buttons [i].interactable = false;			
			}
		}      
        
        
	}
	
	// Update is called once per frame
	void Update () {
        persistence.levelstatus = playerprefsx.GetIntArray("LevelStatus");

        for (int i = 0; i < buttons.Length; i++)
        {
            if (persistence.levelstatus[i] > 0)
            {
                buttons[i].interactable = true;
            }else{
                buttons[i].interactable = false;
            }
        }

        if (PlayerPrefs.GetInt("new game") == 1)
        {
            continueBotao.interactable = true;
        }
        else
        {
            continueBotao.interactable = false;
        }

    }

	public void sair(){
		Application.Quit ();

	}

    public void Cheat() {
        playerprefsx.SetIntArray("LevelStatus", persistence.levelstatus = new int[] { 1, 1, 1 });
    }

	public void Play(){
        Invoke("Play2", 1);
	}

    public void Play2() {
        myLoad.Loading("select_stage");
        PlayerPrefs.SetInt("menuInicial", 0);
    }

	public void voltarMenu(){
        Invoke("voltarMenu1", 1);
    }

    public void voltarMenu1()
    {
        myLoad.Loading("menu");
        PlayerPrefs.SetInt("menuInicial", 1);
        Time.timeScale = 1;
        //PlayerPrefs.SetInt("menuInicial", 1);
    }

    public void selectLevel(string scenetogo){
		myLoad.Loading (scenetogo);
        Time.timeScale = 1;
    }

    public void GamePause() {
        Time.timeScale = 0;
    }

    public void Continue()
    {
        Time.timeScale = 1;
    }

    public void ContinueMenuInicial()
    {        
            myLoad.Loading("select_stage");
            Time.timeScale = 1;
            persistence.LoadData();   
    }
    public void newGame(){
        PlayerPrefs.SetInt("victory", 0);
        PlayerPrefs.SetInt("new game", 1);
        myLoad.Loading("select_stage");
        persistence.resetdata();
        playerprefsx.SetIntArray("LevelStatus", persistence.levelstatus = new int[] { 1, 0, 0 });
        Time.timeScale = 1;
     }

    public void resetFULL() {
        persistence.resetdata();
        PlayerPrefs.SetInt("new game", 0);

    }

    public void fechar() {

        Time.timeScale = 1;
    }
    
}
