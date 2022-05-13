using Exp.Util.Extension;

namespace Exp.Util {
    public class LogHandler {
        #region Properties / Felder
        public FileInfo LogPathFile { get; init; }
        public bool CreatePathWhenMissing { get; set; } = true;
        public PriorityEnum LogLevel { get; set; } = PriorityEnum.Information;
        #endregion

        #region Konstruktor
        public LogHandler(FileInfo aLogPathFile) {
            if (aLogPathFile == null || !aLogPathFile.Exists) {
                throw new Exception.MissingParameterException(nameof(aLogPathFile));
            } else {
                LogPathFile = aLogPathFile;
            }
        }

        public LogHandler(string aLogPathFileName)
            : this(aLogPathFileName.ToFileInfo()) { }
        #endregion

        #region Methoden
        private string CreateLogLine(DateTime aOccurrence, PriorityEnum aPriority, string aMessage) {
            return string.Format("{0} {1}   {2}",
                LogLevel.ID >= PriorityEnum.Information.ID ? aOccurrence.DateTimeFull() : aOccurrence.DateTimeFull4Debug(),
                aPriority.ToString(),
                aMessage);
        }
        #endregion
    }
}