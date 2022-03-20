namespace RtD.Data {
    public class EnemyClassData : DataBase {
        internal EnemyClassData(Json.EnemyClass.EnemyClassJsonData aJsonData, uint aSortOrder)
            : base(aJsonData.ID, aJsonData.Name, aJsonData.Description, aSortOrder) { }
    }
}