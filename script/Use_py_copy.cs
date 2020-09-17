using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Diagnostics;

public class Use_py_copy : MonoBehaviour
{    //pythonがある場所
    private string pyExePath = @"C:\Users\s_sav\anaconda3\python.exe";

    //実行したいスクリプトがある場所
    private string pyCodePath = @"C:\Users\s_sav\cremap.py";

    private void Start()
    {
        //外部プロセスの設定
        ProcessStartInfo processStartInfo = new ProcessStartInfo()
        {
            FileName = pyExePath, //実行するファイル(python)
            UseShellExecute = false,//シェルを使うかどうか
            CreateNoWindow = true, //ウィンドウを開くかどうか
            RedirectStandardOutput = true, //テキスト出力をStandardOutputストリームに書き込むかどうか


            Arguments = pyCodePath + " " + "Hello,python.", //実行するスクリプト 引数(複数可)
        };

        //外部プロセスの開始
        Process process = Process.Start(processStartInfo);
        //ストリームから出力を得る
        StreamReader streamReader = process.StandardOutput;
        string str = streamReader.ReadLine();

        //外部プロセスの終了
        process.WaitForExit();
        process.Close();

        //実行
        print(str);
    }
}