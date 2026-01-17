using System;

class Program
{
    // ステージのサイズ
    const int StageWidth = 10;
    const int StageHeight = 20;

    // ステージの実体
    static int[,] stage = new int[StageHeight, StageWidth];

    // 落ちてくるブロックの情報
    // ブロックの左上の座標
    static int playerX = 4;
    static int playerY = 0;

    // 現在のブロックの形
    static int[,] currentBlock = new int[4, 4]
    {
        { 0, 0, 0, 0 },
        { 1, 1, 1, 1 },
        { 0, 0, 0, 0 },
        { 0, 0, 0, 0 }
    };

    static void Main(string[] args)
    {
        Console.WriteLine("テトリス作戦、開始...");

        // ここでステージの初期化をする
        InitializeStage();

        // 試しに画面に描画してみる
        DrawGame();

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

    static void DrawGame()
    {
        Console.Clear();

        for (int y = 0; y < StageHeight; y++)
        {
            Console.Write("|");

            for (int x = 0; x < StageWidth; x++)
            {
                bool isBlock = false;

                if (x >= playerX && x < playerX + 4 &&
                    y >= playerY && y < playerY + 4)
                {
                    int bx = x - playerX;
                    int by = y - playerY;

                    if (currentBlock[by, bx] == 1)
                    {
                        isBlock = true;
                    }
                }

                if (isBlock)
                {
                    Console.Write("[]");
                }
                else if (stage[y, x] == 0)
                {
                    Console.Write(" .");
                }
                else
                {
                    Console.Write("[]");
                }
            }
            Console.WriteLine("|");
        }
        Console.WriteLine("================================");
    }
}