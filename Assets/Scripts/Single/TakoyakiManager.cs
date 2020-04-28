using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TakoyakiGame.Main
{
    public class TakoyakiManager : MonoBehaviour
    {
        //Prefabのたこ焼きオブジェクトを格納
        [SerializeField]
        private GameObject takoyakiObject = null;

        //毎フレーム呼び出される
        private void Update()
        {
            //もしエンターキーが押されたら
            if (Input.GetKeyDown(KeyCode.Return))
            {
                //CreateTakoyakiメソッドを呼び出す
                CreateTakoyaki();
            }
        }

        //たこ焼きを生成するメソッド
        private void CreateTakoyaki()
        {
            //Instantiateでオブジェクトの生成、これ大事
            Instantiate(takoyakiObject, transform);
        }
    }
}