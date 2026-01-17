using System;

class Program
{
    // ステージのサイズ
    const int StageWidth = 10;
    const int StageHeight = 20;

    // ステージの実体
    static int[,] stage = new int[StageHeight, StageWidth];

    static void Main(string[] args)
    {
        Console.WriteLine("テトリス作戦、開始...");

        // ここでステージの初期化をする
        InitializeStage();

        // 試しに画面に描画してみる
        DrawStage();

        // 勝手に終了しないようにキー入力を待つ
        Console.ReadKey();
    }

    static void InitializeStage()
    {
        for (int y = 0; y < StageHeight; y++)
        {
            for (int x = 0; x < StageWidth; x++)
            {
                stage[y, x] = 0;
            }
        }
    }

    static void DrawStage()
    {
        Console.Clear();

        for (int y = 0; y < StageHeight; y++)
        {
            for (int x = 0; x < StageWidth; x++)
            {
                if (stage[y, x] == 0)
                {
                    Console.Write(" .");
                }
                else
                {
                    Console.Write("[]");
                }
            }
            Console.WriteLine();
        }
    }
}