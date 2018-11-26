using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Camera cam = gameObject.GetComponent<Camera>();

        //理想の画面の比率
        //    float targetRatio = 9f / 16f;
        //現在の画面の比率
        //    float currentRatio = Screen.width * 1f / Screen.height;
        //理想と現在の比率
        //    float ratio = targetRatio / currentRatio;

        //カメラの描画開始位置をX座標にどのくらいずらすか
        //    float rectX = (1.0f - ratio) / 2f;
        //カメラの描画開始位置と表示領域の設定
        //    cam.rect = new Rect(rectX, 0f, ratio, 1f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Awake()
    {

        // 開発している画面を元に縦横比取得 (縦画面) iPhone6, 6sサイズ
        float developAspect = 720f / 1280f;
        // 横画面で開発している場合は以下の用に切り替えます
        //float developAspect = 1334.0f / 750.0f;

        // 実機のサイズを取得して、縦横比取得
        float deviceAspect = (float)Screen.width / (float)Screen.height;

        // 実機と開発画面との対比
        float scale = deviceAspect / developAspect;

        Camera mainCamera = Camera.main;

        // カメラに設定していたorthographicSizeを実機との対比でスケール
        float deviceSize = mainCamera.orthographicSize;
        // scaleの逆数
        float deviceScale = 1.0f / scale;
        // orthographicSizeを計算し直す
        mainCamera.orthographicSize = deviceSize * deviceScale;

    }

}