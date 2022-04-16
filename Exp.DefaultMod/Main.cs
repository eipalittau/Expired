namespace Exp.DefaultMod
{
    public class Main
    {
        public void test() {
            Api.General.DiceType.Singleton.Add("W4", 4, 100);
            Api.General.DiceType.Singleton.Add("W6", 6, 200);
            Api.General.DiceType.Singleton.Add("W8", 8, 300);
            Api.General.DiceType.Singleton.Add("W10", 10, 400);
            Api.General.DiceType.Singleton.Add("W12", 12, 500);
            Api.General.DiceType.Singleton.Add("W20", 20, 600);
            Api.General.DiceType.Singleton.Add("W100", 100, 700);

            Api.Enemy.EnemyClass.Singleton.Add("Magier", 100);
            Api.Enemy.EnemyClass.Singleton.Add("Kleriker", 200);
            Api.Enemy.EnemyClass.Singleton.Add("Schurke", 300);

            Api.Equipment.ItemQuality.Singleton.Get("Normal").DowngradeID = "";


            //Add("Rostig", null, "Schartig", 100, string.Empty, true, false);
            //Add("Schartig", "Rostig", "Normal", 200, string.Empty, true, false);
            //Add("Normal", "Schartig", "Gehärtet", 100, string.Empty, true, true);
            //Add("Gehärtet", "Normal", "Meisterhaft", 400, string.Empty, true, false);
            //Add("Meisterhaft", "Gehärtet", null, 500, string.Empty, false, false);

        }
    }
}