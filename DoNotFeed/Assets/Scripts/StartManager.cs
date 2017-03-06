using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour {

    void Start() {

    }
		
    void Update() {
		
        //** 안드로이드 일 경우 뒤로가기 버튼 클릭시 어플리케이션 종료한다??? **/
        if (Application.platform == RuntimePlatform.Android) {
			
            if (Input.GetKey(KeyCode.Escape)) {
				
                Application.Quit();
            }
        }
    }

    /** Start 버튼 클릭 시 게임을 시작한다. **/
    public void StartGame() {
		
        Application.LoadLevel("Stage1");   
    }
}
