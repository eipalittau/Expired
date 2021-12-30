namespace RtD.Exceptions.Filesystem {
    public class MissingFileException : ExceptionBase {
        public MissingFileException(FileInfo aPathFile)
             : this(aPathFile.FullName) { }

        public MissingFileException(string aPathFileName)
            : base(1003, aPathFileName) { }
    } // Die Datei '' existiert nicht.
}