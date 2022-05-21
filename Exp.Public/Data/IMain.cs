namespace Exp {
    public interface IMain {
        /// <summary>Liste der Dateinamen welche für diesen Mod als Voraussetzung gelten.</summary>
        List<string> Dependency { get; }

        void Initialize();
    }
}