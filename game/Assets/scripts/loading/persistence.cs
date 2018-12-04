using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class persistence {

	public static string nextLevel;
	public static float musicvolume;
	public static float sfxvolume;
	public static int[] levelstatus={0,0,1};


	public static void SaveData(){

		PlayerPrefs.SetFloat("MVolume", musicvolume);
		PlayerPrefs.SetFloat("SFXVolume", sfxvolume);
		playerprefsx.SetIntArray("LevelStatus", levelstatus);
	}

	public static void LoadData(){
		//a cada vez que inicia o jogo
		musicvolume = PlayerPrefs.GetFloat ("MVolume", 80);
		sfxvolume = PlayerPrefs.GetFloat ("SFXVolume", 80);

		if (PlayerPrefs.HasKey ("LevelStatus")) {
			levelstatus = playerprefsx.GetIntArray ("LevelStatus");

		} else {
			levelstatus = new int[]{1,0,0};		
		}


	}

    public static void cheat_0() {
               

    }
	public static void resetdata(){
		playerprefsx.SetIntArray("LevelStatus", levelstatus = new int[] {1,0,0});
        
		//pensar em algo :(
	}
}
