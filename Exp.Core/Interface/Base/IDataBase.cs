namespace Exp.Data {
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
    public interface IDataBase {
        /// <summary>Eindeutige Identifikation des Datensatzes. Die ID kann zur bei der Erstellung gesetzt werden.</summary>
        /// <exception cref="DublicateItemException">Falls die ID bereits existiert, wird diese Exception geworfen.</exception>
        string ID { get; init; }
        
        /// <summary>Der anzuzeigende Name in der jeweiligen Sprache. Für jede Sprache sollten Daten erfasst werden.</summary>
        Util.LanguageBasedData Name { get; }
        
        /// <summary>Die anzuzeigende Beschreibung in der jeweiligen Sprache. Für jede Sprache sollten Daten erfasst werden.</summary>
        Util.LanguageBasedData LoreDescription { get; }
        
        /// <summary>Ein nummerischer Wert für die Sortierung der Datensätze.</summary>
        int SortWeight { get; set; }
    }
}
