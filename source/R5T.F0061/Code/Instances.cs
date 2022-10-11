using System;

using R5T.F0033;
using R5T.T0146;


namespace R5T.F0061
{
    public static class Instances
    {
        public static INotepadPlusPlusOperator NotepadPlusPlusOperator { get; } = F0033.NotepadPlusPlusOperator.Instance;
        public static IResultSerializer ResultSerializer { get; } = T0146.ResultSerializer.Instance;
    }
}