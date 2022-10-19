using System;

using R5T.F0000;
using R5T.F0033;
using R5T.T0146;
using R5T.Z0015;


namespace R5T.F0061
{
    public static class Instances
    {
        public static IFileOperator FileOperator { get; } = F0000.FileOperator.Instance;
        public static IFilePaths FilePaths { get; } = Z0015.FilePaths.Instance;
        public static INotepadPlusPlusOperator NotepadPlusPlusOperator { get; } = F0033.NotepadPlusPlusOperator.Instance;
        public static IResultSerializer ResultSerializer { get; } = T0146.ResultSerializer.Instance;
    }
}