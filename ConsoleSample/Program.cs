﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;   // 追加：「参照」でSystem.Drawingを追加すること
using ImagingSolution;  // ImagingSolution.Matクラス用

namespace ConsoleSample
{
    class Program
    {
        static void Main(string[] args)
        {
            // 行列(matA)の設定（二次元配列で行列を設定）
            var matA = new double[,] {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            matA.Print("matA =");　// コンソールへ行列の表示

            // 行列(matB)の設定
            var matB = new double[,] {
                { 1, 4, 8 },
                { 6, 2, 5 },
                { 9, 7, 3 }
            };
            matB.Print("matB =");

            // 行列(matA)と行列(matA)の積
            var matMult = matA.Mult(matB);
            matMult.Print("matA matB =");

            // 行列(matA)と行列(matA)の加算
            var matAdd = matA.Add(matB);
            matAdd.Print("matA + matB =");

            // 行列(matA)と行列(matA)の減算
            var matSub = matA.Sub(matB);
            matSub.Print("matA - matB =");

            // 行列(matB)の逆行列
            var matInverse = matB.Inverse();
            matInverse.Print("(matB)-1 =");

            // 行列(matA)の転置
            var matTranspose = matA.Transpose();
            matTranspose.Print("(matA)T =");

            // 回転行列の取得
            var matRotate = Mat.RotateMat(10.0);
            matRotate.Print("RotateMat =");

            // 拡大行列の取得
            var matScale = Mat.ScaleMat(2.0, 5.0);
            matScale.Print("ScaleMat =");

            // 平行移動行列の取得
            var matTranslate = Mat.TranslateMat(-5.0, 12.0);
            matTranslate.Print("TranslateMat =");

            Bitmap bmp;
            // 画像ファイルを開く
            var imgMat = Mat.Imread("0.bmp", out bmp);
            imgMat.Print("Image data =");

            // 画像の表示
            var window = bmp.Imshow("Image");

            // 配列(画像データ)をcsvファイルに保存
            imgMat.SaveCsv("matData.csv");

            // キー入力待ち
            Console.WriteLine("続行するには何かキーを押してください . . .");
            Console.ReadKey();
        }
    }
}

