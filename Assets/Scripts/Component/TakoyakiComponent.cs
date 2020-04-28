using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TakoyakiGame.Main
{
    public class TakoyakiComponent : MonoBehaviour
    {
        //落ちるスピード、constは定数の宣言
        private const float SPEED = 0.01f;

        //落ちているかのフラグ
        private bool falling;

        //生成された時
        private void Start()
        {
            //落ちる状態にする
            falling = true;
        }

        private void Update()
        {
            //もし落ちている状態ならば
            if (falling)
            {
                //毎フレームFallメソッドを呼び出す
                Fall();
            }
        }

        //落ちるメソッド
        private void Fall()
        {
            //現在の座標を取得
            Vector2 pos = transform.position;

            //Y座標からSPEEDを引く
            pos.y -= SPEED;

            //引いたものを現在の座標にする
            transform.position = pos;

            //つまり毎フレームY座標からSPEED分引かれていく仕組み
        }
    }
}